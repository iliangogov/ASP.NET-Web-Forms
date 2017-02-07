using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Countries.Data.Models;
using Todos.Data;
using Todos.Web;

namespace Todos
{
    public partial class _Default : Page
    {
        TodosDbContext data = new TodosDbContext();

        private const int PageSize = 5;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["page"] = 0;
            }
        }

        public IQueryable<Todo> ListViewTodos_GetData()
        {
            var todos = data.Todos.OrderBy(x => x.Id);
            var dateOrder = (string)ViewState["orderByDate"];
            if (dateOrder != null && dateOrder == "asc")
            {
                todos = todos.OrderBy(x => x.LastChanged);
            }
            else if (dateOrder != null && dateOrder == "des")
            {
                todos = todos.OrderByDescending(x => x.LastChanged);
            }

            int page = (int)ViewState["page"];
            return todos.Skip(PageSize * page).Take(PageSize);
        }

        public IQueryable<Category> GetGategories()
        {
            return data.Categories.OrderBy(x => x.Id);
        }

        public List<Todo> FormViewTodos_GetData()
        {
            if (ViewState["selectedTodo"] == null)
            {
                return new List<Todo>();
            }

            var id = (string)ViewState["selectedTodo"];
            var foundTodo = data.Todos.Find(int.Parse(id));
            return new List<Todo> { foundTodo };
        }

        protected void ListViewTodos_ServerClick(object sender, EventArgs e)
        {
            var element = (HtmlControl)sender;
            var id = element.Attributes["itemid"];
            ViewState.Add("selectedTodo", id);
            FormViewTodoDetails.ChangeMode(FormViewMode.ReadOnly);
            this.FormViewTodoDetails.DataBind();
        }

        public void FormViewTodoDetails_UpdateItem(int id)
        {
            Todo item = null;
            item = data.Todos.Find(id);
            if (item == null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            TryUpdateModel(item);

            if (ModelState.IsValid)
            {
                data.Entry(item).State = EntityState.Modified;
                data.SaveChanges();
                DisplayMessage("Item updated");
            }
        }

        protected void AddNewButton_Click(object sender, EventArgs e)
        {
            this.FormViewTodoDetails.ChangeMode(FormViewMode.Insert);
        }

        public void FormViewTodoDetails_InsertItem()
        {
            var item = new Todo();
            TryUpdateModel(item);
            var dropDownCategories = (DropDownList)this.FormViewTodoDetails.FindControl("DropDownListCategoriesList");
            item.CategoryId = int.Parse(dropDownCategories.SelectedValue);

            if (ModelState.IsValid)
            {
                var id = data.Todos.Add(item);
                data.SaveChanges();
                var master = this.Master as Site;
                DisplayMessage("Item added");
                this.ListViewTodos.DataBind();
            }
        }

        public void FormViewTodoDetails_DeleteItem(int id)
        {
            var item = data.Todos.Find(id);
            data.Todos.Remove(item);
            data.SaveChanges();
            DisplayMessage("Item deleted");
            ViewState["selectedTodo"] = null;
            this.ListViewTodos.DataBind();
            this.FormViewTodoDetails.DataBind();
        }

        private void DisplayMessage(string msg)
        {
            var master = this.Master as Site;
            master.ShowSuccessMessage(msg);
        }

        protected void orderByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropDown = (DropDownList)sender;
            var selectedItem = dropDown.SelectedItem;
            ViewState.Add("orderByDate", selectedItem.Text);
            FirstPage_ServerClick(new { }, new EventArgs());
            this.ListViewTodos.DataBind();
        }

        protected void NextPage_ServerClick(object sender, EventArgs e)
        {
            int page = (int)ViewState["page"];
            if (page * PageSize < data.Todos.Count() - PageSize)
            {
                ViewState["page"] = ++page;
                this.ListViewTodos.DataBind();
            }

        }

        protected void PrevPage_ServerClick(object sender, EventArgs e)
        {
            int page = (int)ViewState["page"];
            if (page > 0)
            {
                ViewState["page"] = --page;
                this.ListViewTodos.DataBind();
            }
        }

        protected void FirstPage_ServerClick(object sender, EventArgs e)
        {
            ViewState["page"] = 0;
            this.ListViewTodos.DataBind();

        }

        protected void LastPage_ServerClick(object sender, EventArgs e)
        {
            var totalCount = data.Todos.Count();

            var lastPage = totalCount / PageSize;
            if (totalCount % PageSize == 0)
            {
                lastPage--;
            }

            ViewState["page"] = lastPage;
            this.ListViewTodos.DataBind();
        }
    }
}