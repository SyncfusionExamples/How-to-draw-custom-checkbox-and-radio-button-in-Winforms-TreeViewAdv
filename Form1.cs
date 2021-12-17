using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_checkbox_and_radiobutton
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Represents the TreeViewAdv.
        /// </summary>
        private TreeViewAdv treeViewAdv1;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.treeViewAdv1 = new TreeViewAdv();
            this.treeViewAdv1.ItemHeight = 25;
            this.treeViewAdv1.Dock = DockStyle.Fill;
            this.treeViewAdv1.SelectionMode = TreeSelectionMode.MultiSelectAll;
            this.treeViewAdv1.SelfRelationRootValue = "";
            this.treeViewAdv1.ShowRootLines = true;
            this.treeViewAdv1.ShowLines = true;
            this.treeViewAdv1.ThemeName = "Office2019Colorful";

            DataTable dataTable1 = new DataTable("Continent");
            dataTable1.Columns.Add("Name", typeof(string));
            dataTable1.Columns.Add("CountryID", typeof(string));
            dataTable1.Columns.Add("ContinentID", typeof(string));
            dataTable1.Columns.Add("Capital", typeof(string));
            dataTable1.Columns.Add("IsActive", typeof(bool));
            dataTable1.Rows.Add("Asia", "1", "", "Asia", true);
            dataTable1.Rows.Add("India", "2", "1", "Delhi", false);
            dataTable1.Rows.Add("China", "3", "1", "Beijing", true);
            dataTable1.Rows.Add("North America", "4", "", "USA", false);
            dataTable1.Rows.Add("United States", "5", "4", "New York", true);
            dataTable1.Rows.Add("Canada", "6", "4", "Ottawa", false);
            dataTable1.Rows.Add("Europe", "7", "", "EU", true);
            dataTable1.Rows.Add("UK", "8", "7", "London", false);
            dataTable1.Rows.Add("Russia", "9", "7", "Moscow", true);
            dataTable1.Rows.Add("Africa", "10", "", "SA", false);
            dataTable1.Rows.Add("South Africa", "11", "10", "Cape Town", true);
            dataTable1.Rows.Add("Zimbabwe", "12", "10", "Harare", false);
            dataTable1.Rows.Add("Maharashtra", "13", "2", "Bombay", true);
            dataTable1.Rows.Add("Tamil Nadu", "14", "2", "Madras", false);
            dataTable1.Rows.Add("Mumbai", "15", "13", "Borivali", true);
            dataTable1.Rows.Add("Chennai", "16", "14", "Koyambedu", false);
            dataTable1.Rows.Add("New York", "17", "5", "NY", true);
            dataTable1.Rows.Add("Albany", "18", "17", "AL", false);
            dataTable1.Rows.Add("Northen Cape", "19", "11", "NC", true);
            dataTable1.Rows.Add("CapeTown", "20", "19", "Town", false);
            dataTable1.Rows.Add("England", "21", "8", "ENG", true);
            dataTable1.Rows.Add("London", "22", "21", "UK", false);
            dataTable1.Rows.Add("Shanghai", "23", "3", "SH", true);
            dataTable1.Rows.Add("Republics", "24", "9", "Repb", false);
            dataTable1.Rows.Add("Kazan", "25", "24", "Kz", true);
            dataTable1.Rows.Add("Victoria", "26", "12", "VC", false);
            dataTable1.Rows.Add("Masvingo", "27", "26", "Mas", true);
            dataTable1.Rows.Add("Chengudu", "28", "23", "Chen", false);
            dataTable1.Rows.Add("Ontario", "29", "6", "Ont", true);
            dataTable1.Rows.Add("Toronto", "30", "29", "TR", true);

            this.treeViewAdv1.DataMember = "Continent";
            this.treeViewAdv1.DisplayMember = "Name";
            this.treeViewAdv1.ParentMember = "ContinentID";
            this.treeViewAdv1.ChildMember = "CountryID";
            this.treeViewAdv1.ValueMember = "Capital";
            this.treeViewAdv1.CheckedMember = "IsActive";
            this.treeViewAdv1.DataSource = dataTable1;
            this.treeViewAdv1.DrawNodeCheckBox += treeViewAdv1_DrawCustomCheckBox;

            this.panel1.Controls.Add(treeViewAdv1);
        }


        /// <summary>
        /// occurs when checked property is changed.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> contains the event data.</param>
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                this.treeViewAdv1.ShowOptionButtons = true;
                this.checkBox1.Checked = false;
            }
            else
                this.treeViewAdv1.ShowOptionButtons = false;
        }

        /// <summary>
        /// occurs when checked property is changed.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> contains the event data.</param>
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                this.treeViewAdv1.ShowCheckBoxes = true;
                this.checkBox2.Checked = false;
            }
            else
                this.treeViewAdv1.ShowCheckBoxes = false;
        }

        /// <summary>
        /// occurs when draw node checkbox event is raised.
        /// </summary>
        /// <param name="sender">The Source of the event.</param>
        /// <param name="e">The <see cref="DrawTreeViewAdvNodeEventArgs"/> contains the event data.</param>
        void treeViewAdv1_DrawCustomCheckBox(object sender, DrawTreeViewAdvNodeEventArgs e)
        {
            if (e.Node.CheckBox != null && e.Node.CheckBox.Visible)
            {
                Rectangle checkBoxBounds = e.Bounds;
                Brush backgroundColor = new SolidBrush(Color.LightCyan);
                Brush borderColor = new SolidBrush(Color.DarkBlue);
                Brush tickColor = new SolidBrush(Color.Green);
                Brush indeterminateColor = new SolidBrush(Color.Green);

                if (e.Node.CheckBox.Bounds.Contains(e.Node.TreeView.PointToClient(Cursor.Position)) && this.Enabled)
                {
                    backgroundColor = new SolidBrush(Color.LightGreen);
                    borderColor = new SolidBrush(Color.Red);
                    tickColor = new SolidBrush(Color.DarkRed);
                    indeterminateColor = new SolidBrush(Color.DarkRed);
                }
                if (e.State == ButtonState.Checked)
                {
                    e.Graphics.FillRectangle(backgroundColor, checkBoxBounds);
                    e.Graphics.DrawRectangle(new Pen(borderColor, 1), checkBoxBounds);
                    checkBoxBounds.Inflate(-1, -1);

                    Point[] points = new Point[]
                            {
                       new Point(checkBoxBounds.X + (int)Math.Ceiling(DpiAware.LogicalToDeviceUnits(1)), checkBoxBounds.Y + (checkBoxBounds.Height / 2)),
                       new Point(checkBoxBounds.X + (checkBoxBounds.Width / 2) - (int)Math.Ceiling(DpiAware.LogicalToDeviceUnits(1)), checkBoxBounds.Bottom - (int)Math.Ceiling(DpiAware.LogicalToDeviceUnits(3))),
                       new Point(checkBoxBounds.Right - (int)Math.Ceiling(DpiAware.LogicalToDeviceUnits(2)), checkBoxBounds.Top + (int)Math.Ceiling(DpiAware.LogicalToDeviceUnits(2)))
                            };

                    SmoothingMode prevMode = e.Graphics.SmoothingMode;
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawLines(new Pen(tickColor, 1), points);
                    e.Graphics.SmoothingMode = prevMode;
                }
                else if (e.State == ButtonState.Normal)
                {
                    Pen uncheckedBorder = new Pen(borderColor, 1);
                    uncheckedBorder.Alignment = PenAlignment.Inset;
                    e.Graphics.FillRectangle(backgroundColor, checkBoxBounds);
                    e.Graphics.DrawRectangle(uncheckedBorder, checkBoxBounds);
                    checkBoxBounds.Inflate(-1, -1);
                    uncheckedBorder.Dispose();
                }
                else if (e.State == ButtonState.All)
                {
                    Pen indeterminateBorderPen = new Pen(borderColor, 1);
                    indeterminateBorderPen.Alignment = PenAlignment.Inset;
                    e.Graphics.FillRectangle(backgroundColor, checkBoxBounds);
                    e.Graphics.DrawRectangle(indeterminateBorderPen, checkBoxBounds);
                    checkBoxBounds.Inflate(-1, -1);
                    checkBoxBounds.Inflate(-3, -3);
                    e.Graphics.FillRectangle(indeterminateColor, checkBoxBounds);
                    indeterminateBorderPen.Dispose();
                }
            }
            else 
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Rectangle rectangle = e.Bounds;
                rectangle.Inflate(-1, -1);
                Pen outerCircle = new Pen(Color.Red);
                SolidBrush innerCircle = new SolidBrush(Color.Red);

                if (e.State == ButtonState.Checked)
                {
                    outerCircle = new Pen(Color.Green);
                }

                if (e.Node.OptionButton.Bounds.Contains(e.Node.TreeView.PointToClient(Cursor.Position)) && this.Enabled)
                {
                    outerCircle = new Pen(Color.BlueViolet);
                    innerCircle = new SolidBrush(Color.DarkBlue);
                }

                e.Graphics.FillEllipse(new SolidBrush(Color.White), rectangle);
                e.Graphics.DrawEllipse(outerCircle, rectangle);
                rectangle.Inflate(-1, -1);
                outerCircle.Dispose();
                if (e.State == ButtonState.Checked)
                {
                    rectangle.Inflate(-2, -2);
                    e.Graphics.FillEllipse(innerCircle, rectangle);
                    innerCircle.Dispose();
                }
            }
            e.Handled = true;
        }
    }
}
