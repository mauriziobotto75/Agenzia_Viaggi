
using System;
using System.Drawing;
using System.Windows.Forms;

public class ClientiForm : Form
{
    public ClientiForm()
    {
        Text = "Gestione Clienti";
        Width = 400;
        Height = 250;

        var lblNome = new Label { Text = "Nome:", Top = 20, Left = 20 };
        var txtNome = new TextBox { Text = "Viola", Top = 20, Left = 100, Width = 250 };

        var lblCognome = new Label { Text = "Cognome:", Top = 50, Left = 20 };
        var txtCognome = new TextBox { Text = "Altipola", Top = 50, Left = 100, Width = 250 };

        var lblCitta = new Label { Text = "Città:", Top = 80, Left = 20 };
        var txtCitta = new TextBox { Text = "VREA", Top = 80, Left = 100, Width = 250 };

        var lblTelefono = new Label { Text = "Telefono:", Top = 110, Left = 20 };
        var txtTelefono = new TextBox { Text = "(0125)78345", Top = 110, Left = 100, Width = 250 };

        var lblRecord = new Label { Text = "Record 53 di 54", Top = 150, Left = 20 };

        var btnBack = new Button { Text = "Torna al Menu", Top = 180, Left = 20, Width = 150, ImageAlign = ContentAlignment.MiddleLeft };
        btnBack.Image = SystemIcons.Hand.ToBitmap();
        btnBack.Click += (s, e) => { new MenuStampeForm().Show(); Close(); };

        Controls.AddRange(new Control[] {
            lblNome, txtNome,
            lblCognome, txtCognome,
            lblCitta, txtCitta,
            lblTelefono, txtTelefono,
            lblRecord, btnBack
        });
    }
}
