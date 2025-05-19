using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caserne
{
    public partial class UcMission : UserControl
    {
        public Button BtnTerminer => btnTerminer;
        public Button BtnPDF => btnPDF;
        public UcMission()
        {
            InitializeComponent();
        }

        public string IdMission
        {
            get => lblID.Text;
            set => lblID.Text = "Id mission : " + value;
        }

        public string DateMission
        {
            get => lblDate.Text;
            set => lblDate.Text = "Début le : " + value;
        }

        public string Caserne
        {
            get => lblCaserne.Text;
            set => lblCaserne.Text = "Caserne : " + value;
        }

        public string Description
        {
            get => lblDesc.Text;
            set => lblDesc.Text = "--> " + value;
        }

        public string NatureSinistre
        {
            get => lblNature.Text;
            set => lblNature.Text = value;
        }
    }
}
