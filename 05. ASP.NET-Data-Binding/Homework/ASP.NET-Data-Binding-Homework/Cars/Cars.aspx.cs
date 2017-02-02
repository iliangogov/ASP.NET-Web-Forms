using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cars
{
    public partial class Cars : System.Web.UI.Page
    {
        private IList<Producer> producers;
        private IList<Extra> extras;
        private IList<string> engineTypes;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.SeedData();

            if (!this.Page.IsPostBack)
            {
                this.ProducersDropDownList.DataSource = this.producers;
                this.ProducersDropDownList.DataBind();

                this.ProducerModelsDropDownList.DataSource = this.producers[0].Models;
                this.ProducerModelsDropDownList.DataBind();

                this.ExtrasCheckBoxList.DataSource = this.extras;
                this.ExtrasCheckBoxList.DataBind();

                this.EnginesRadioButtonList.DataSource = this.engineTypes;
                this.EnginesRadioButtonList.DataBind();
                this.EnginesRadioButtonList.SelectedIndex = 0;
            }
        }

        protected void OnProducerSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProducer = this.producers[this.ProducersDropDownList.SelectedIndex];
            this.ProducerModelsDropDownList.DataSource = selectedProducer.Models;
            this.ProducerModelsDropDownList.DataBind();
        }

        protected void OnSearchButtonClicked(object sender, EventArgs e)
        {
            var selectedProducer = this.ProducersDropDownList.Text;
            var selectedModel = this.ProducerModelsDropDownList.Text;
            var selectedExtras = this.ExtrasCheckBoxList.Items
                                     .Cast<ListItem>()
                                     .Where(x => x.Selected)
                                     .Select(x => x.Text);
            var actualExtras = selectedExtras.Any() ? string.Join(", ", selectedExtras) : "without extras";
            var selectedEngine = this.EnginesRadioButtonList.SelectedValue;

            this.SummaryLiteral.Text = string.Format("Results for: \n {0}, {1}, {2}, {3}",
                                                    selectedProducer,
                                                    selectedModel,
                                                    selectedEngine,
                                                    actualExtras);
        }

        protected void SeedData()
        {
            // Adding producers
            this.producers = new List<Producer>();

            this.producers.Add(new Producer()
            {
                Name = "BMW",
                Models = new List<Model>()
                {
                    new Model() {Name="530d"},
                    new Model() {Name="X5"},
                    new Model() {Name="330xd"}
                }
            });

            this.producers.Add(new Producer()
            {
                Name = "Audi",
                Models = new List<Model>()
                {
                    new Model() {Name="A4"},
                    new Model() {Name="Q7"},
                    new Model() {Name="TT"}
                }
            });

            this.producers.Add(new Producer()
            {
                Name = "Volvo",
                Models = new List<Model>()
                {
                    new Model() {Name="s60"},
                    new Model() {Name="c30"},
                    new Model() {Name="xc90"}
                }
            });

            //Adding extras
            this.extras = new List<Extra>()
            {
                new Extra() {Name="Xenon" },
                new Extra() {Name="Navigation" },
                new Extra() {Name="Automatic Transmission" },
                new Extra() {Name="Heated Seats" },
            };

            //Adding engine types
            this.engineTypes = new List<string>()
            {
                "diesel",
                "gasoline",
                "metane",
                "LPG"
            };
        }
    }
}