using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private bool IsPlayersTurn = true;
    private string Winner = "";

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected string HandleGetSymbol()
    {
        if (!IsPlayersTurn)
        {
            return "O";
        }
        else
        {
            return "X";
        }
    }

    protected void SwitchPlayer()
    {
        if (this.IsPlayersTurn)
        {
            this.IsPlayersTurn = false;
            playerLabel.Text = "VEZ DO SEU AMIGO";
        }
        else
        {
            this.IsPlayersTurn = true;
            playerLabel.Text = "SUA VEZ";
        }

        this.HandleCheckWinner();
    }

    protected void OnButton11Clicked(object sender, EventArgs e)
    {
        button1_1.Label = this.HandleGetSymbol();
        button1_1.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void OnButton12Clicked(object sender, EventArgs e)
    {
        button1_2.Label = this.HandleGetSymbol();
        button1_2.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void OnButton13Clicked(object sender, EventArgs e)
    {
        button1_3.Label = this.HandleGetSymbol();
        button1_3.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void OnButton21Clicked(object sender, EventArgs e)
    {
        button2_1.Label = this.HandleGetSymbol();
        button2_1.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void OnButton22Clicked(object sender, EventArgs e)
    {
        button2_2.Label = this.HandleGetSymbol();
        button2_2.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void OnButton23Clicked(object sender, EventArgs e)
    {
        button2_3.Label = this.HandleGetSymbol();
        button2_3.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void OnButton31Clicked(object sender, EventArgs e)
    {
        button3_1.Label = this.HandleGetSymbol();
        button3_1.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void OnButton32Clicked(object sender, EventArgs e)
    {
        button3_2.Label = this.HandleGetSymbol();
        button3_2.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void OnButton33Clicked(object sender, EventArgs e)
    {
        button3_3.Label = this.HandleGetSymbol();
        button3_3.Sensitive = false;
        this.SwitchPlayer();
    }

    protected void GetWinner(string symbol)
    {
        if (symbol == "X")
        {
            this.Winner = "VOCÊ VENCEU";
        }
        else
        {
            this.Winner = "SEU AMIGO VENCEU";
        }

        winnerLabel.Text = this.Winner;

        button1_1.Sensitive = false;
        button1_2.Sensitive = false;
        button1_3.Sensitive = false;
        button2_1.Sensitive = false;
        button2_2.Sensitive = false;
        button2_3.Sensitive = false;
        button3_1.Sensitive = false;
        button3_2.Sensitive = false;
        button3_3.Sensitive = false;
    }

    protected void HandleCheckWinner()
    {
        if(button1_1.Label == button1_2.Label && button1_2.Label == button1_3.Label && button1_1.Label != "-")
        {
            this.GetWinner(button1_1.Label);
        }
        else if(button1_1.Label == button2_2.Label && button2_2.Label == button3_3.Label && button3_2.Label != "-")
        {
            this.GetWinner(button1_1.Label);
        } else if(button1_1.Label == button2_1.Label && button2_1.Label == button3_1.Label && button3_1.Label != "-")
        {
            this.GetWinner(button1_1.Label);
        }
        else if (button1_2.Label == button2_2.Label && button2_2.Label == button3_2.Label && button3_2.Label != "-")
        {
            this.GetWinner(button2_1.Label);
        }
        else if (button1_3.Label == button2_3.Label && button2_3.Label == button3_3.Label && button3_3.Label != "-")
        {
            this.GetWinner(button1_3.Label);
        }
        else if (button1_3.Label == button2_2.Label && button2_2.Label == button3_1.Label && button3_1.Label != "-")
        {
            this.GetWinner(button1_3.Label);
        }
        else if (button2_1.Label == button2_2.Label && button2_2.Label == button2_3.Label && button2_3.Label != "-")
        {
            this.GetWinner(button2_1.Label);
        }
        else if (button3_1.Label == button3_2.Label && button3_2.Label == button3_3.Label && button3_3.Label != "-")
        {
            this.GetWinner(button3_1.Label);
        }
    }
}
