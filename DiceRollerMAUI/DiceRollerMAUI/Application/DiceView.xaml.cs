using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerMAUI.Application;

// Create a view where we can see the title of the dice category (and be able to edit it by automatically changing to a textfield) and a list below with all the possible options of the dice category where the user can enter more or delete existing ones.

public partial class DiceView : ContentPage
{
    public DiceView()
    {
        InitializeComponent();
    }
    
    private void OnEditClicked(object sender, EventArgs e)
    {
        TitleTextField.IsVisible = true;
        TitleTextField.Focus();
    }
    
}