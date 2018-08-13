using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalv2
    {
    public partial class CustomMsgBox : Form
        {
        public CustomMsgBox()
            {
            InitializeComponent();
            }

        public static void Mostrar (string error)
            {
                CustomMsgBox MsgBox = new ProyectoFinalv2.CustomMsgBox();
                MsgBox.TextoError.Text = error;
                MsgBox.ShowDialog();
                
            }

        public static void Mostrar(string title, string error)
        {
            CustomMsgBox MsgBox = new ProyectoFinalv2.CustomMsgBox();
            MsgBox.TextoError.Text = error;
            MsgBox.title.Text = title;
            MsgBox.ShowDialog();
        }

        private void TopBar_MouseDown(object sender , MouseEventArgs e)
            {

            }

        private void TopBar_MouseMove(object sender , MouseEventArgs e)
            {

            }

        private void TopBar_MouseUp(object sender , MouseEventArgs e)
            {

            }

        private void CloseButton_Click(object sender , EventArgs e)
            {
                this.Close(); 
            }

        private void TextoError_TextChanged(object sender , EventArgs e)
            {

            }

        private void TextoError_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }
