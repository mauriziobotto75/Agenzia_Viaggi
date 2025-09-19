
using System;
using System.Drawing;
using System.Windows.Forms;

public class TourOperatorForm : Form
{
    public TourOperatorForm()
    {
        Text = "Gestione Tour Operator";
        Width = 400;
        Height = 250;

        var lblNome = new Label { Text = "Nome:", Top = 20, Left = 20 };
        var txtNome = new TextBox { Text = "Top Luxury Megatravels", Top = 20, Left = 100, Width = 250 };

        var lblContatto = new Label { Text = "Contatto:", Top = 50, Left = 20 };
        var txtContatto = new TextBox { Text = "Gastone Soldini", Top = 50, Left = 100, Width = 250 };

        var lblCitta = new Label { Text = "Città:", Top = 80, Left = 20 };
        var txtCitta = new TextBox { Text = "Donaldsville", Top = 80, Left = 100, Width = 250 };

        var lblTelefono = new Label { Text = "Telefono:", Top = 110, Left = 20 };
        var txtTelefono = new TextBox { Text = "800-313313", Top = 110, Left = 100, Width = 250 };

        var lblRecord = new Label { Text = "Record 5 di 5", Top = 150, Left = 20 };

        var btnBack = new Button { Text = "Torna al Menu", Top = 180, Left = 20, Width = 150, ImageAlign = ContentAlignment.MiddleLeft };
        btnBack.Image = SystemIcons.Hand.ToBitmap();
        btnBack.Click += (s, e) => { new MenuStampeForm().Show(); Close(); };

        Controls.AddRange(new Control[] {
            lblNome, txtNome,
            lblContatto, txtContatto,
            lblCitta, txtCitta,
            lblTelefono, txtTelefono,
            lblRecord, btnBack
        });
    }
}
