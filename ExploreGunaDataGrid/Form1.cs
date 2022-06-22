using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploreGunaDataGrid
{
    public partial class Form1 : Form
    {
        private List<ShipmentDetails> _sups;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //generate some data
            _sups = new List<ShipmentDetails>();
            _sups.Add(new ShipmentDetails() { Id = 1, ReceiverName = "Receiver 1", SupplierName = "Supplier 1" });
            _sups.Add(new ShipmentDetails() { Id = 2, ReceiverName = "Greatest Receiver Ever", SupplierName = "Largest Supplier in the World" });
            _sups.Add(new ShipmentDetails() { Id = 3, ReceiverName = "Receiver 3", SupplierName = "Supplier 3" });
            _sups.Add(new ShipmentDetails() { Id = 4, ReceiverName = "King Bob is the greatest Receiver", SupplierName = "Gru is the biggest Supplier" });
            _sups.Add(new ShipmentDetails() { Id = 5, ReceiverName = "Receiver 4", SupplierName = "Supplier 4" });
            _sups.Add(new ShipmentDetails() { Id = 6, ReceiverName = "Receiver of the Century", SupplierName = "Supplier of the Decade" });

            dgvShipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            

            //load data
            foreach (ShipmentDetails sup in _sups)
            {
                dgvShipments.Invoke(new Action(() =>
                {
                    dgvShipments.Rows.Add(sup.Id, sup.SupplierName, sup.ReceiverName, new DataGridViewButtonCell(), new DataGridViewButtonCell());
                }));
            }

            //dgvShipments.Dock = DockStyle.Fill;
            //dgvShipments.DataSource = _sups;
            //dgvShipments.
            //dgvShipments.DefaultCellStyle.Font = new Font("Arial", 9F, GraphicsUnit.Pixel);
            //dgvShipments.Columns[0].DefaultCellStyle.Font = new Font("Arial", 9F, GraphicsUnit.Pixel);
        }

        
    }
}
