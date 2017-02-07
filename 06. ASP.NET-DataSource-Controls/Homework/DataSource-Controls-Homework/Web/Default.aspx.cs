using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Countries.Data;
using Countries.Data.Models;

namespace Countries
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void EntityDataSourceCountries_Selecting(object sender, EntityDataSourceSelectingEventArgs e)
        {

        }

        public IQueryable<Continent> ListBoxContinents_GetData()
        {
            CountriesDbContext data = new CountriesDbContext();
            var continents = data.Continents;
            return continents.OrderBy(x => x.Id);
        }

        public IQueryable<Country> GridViewCountries_GetData()
        {
            var selectedId = ListBoxContinents.SelectedValue;
            int id = 0;
            if (selectedId != "")
            {
                id = int.Parse(selectedId);
            }

            CountriesDbContext data = new CountriesDbContext();
            return data.Countries.Where(x => x.ContinentId == id).OrderBy(x => x.Id);
        }

        protected void GridViewCountries_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] =
                    "this.style.background='#EEEEEE';this.style.cursor='hand'";
                e.Row.Attributes["onmouseout"] =
                    "this.style.background='white'";
                e.Row.Attributes["onclick"] =
                    ClientScript.GetPostBackClientHyperlink(
                    this.GridViewCountries, "Select$" + e.Row.RowIndex);
            }
        }

        public IQueryable<Town> ListViewTowns_GetData()
        {
            object countryId = null;
            if (this.GridViewCountries.SelectedDataKey != null)
            {
                countryId = this.GridViewCountries.SelectedDataKey.Value;
            }

            int id = 0;
            if (countryId != null)
            {
                id = (int)countryId;
            }

            CountriesDbContext data = new CountriesDbContext();
            return data.Towns.Where(x => x.CountryId == id).OrderBy(x => x.Id);

        }

        protected void ListBoxContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GridViewCountries.SelectMethod = "";
            this.GridViewCountries.SelectMethod = "GridViewCountries_GetData";
        }

        protected void GridViewCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListViewTowns.SelectMethod = "";
            this.ListViewTowns.SelectMethod = "ListViewTowns_GetData";
        }
    }
}