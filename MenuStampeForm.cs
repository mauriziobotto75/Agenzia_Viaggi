
using System;
using System.Drawing;
using System.Windows.Forms;

public class MenuStampeForm : Form
{
    public MenuStampeForm()
    {
        Text = "Poltrone volante 2000 - Menu stampe";
        Width = 400;
        Height = 300;

        var btnClienti = new Button { Text = "Gestione Clienti", Top = 20, Left = 20, Width = 200, ImageAlign = ContentAlignment.MiddleLeft };
        btnClienti.Image = SystemIcons.Information.ToBitmap();
        btnClienti.Click += (s, e) => new ClientiForm().Show();

        var btnTour = new Button { Text = "Gestione Tour Operator", Top = 60, Left = 20, Width = 200, ImageAlign = ContentAlignment.MiddleLeft };
        btnTour.Image = SystemIcons.Application.ToBitmap();
        btnTour.Click += (s, e) => new TourOperatorForm().Show();

        var btnExit = new Button { Text = "Esci", Top = 100, Left = 20, Width = 200, ImageAlign = ContentAlignment.MiddleLeft };
        btnExit.Image = SystemIcons.Error.ToBitmap();
        btnExit.Click += (s, e) => Close();

        Controls.AddRange(new Control[] { btnClienti, btnTour, btnExit });
    }
}
