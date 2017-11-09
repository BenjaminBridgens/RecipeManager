using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RecipeManager.DataAccess;
using RecipeManager.Entities;

namespace RecipeManager.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        private IngredientRepository ingRepo;
        private RecipeRepository recRepo;
        List<Recipe> Recipes;
        Recipe currentlySelected;

        public MainWindow()
        {
            InitializeComponent();
            ingRepo = new IngredientRepository();
            recRepo = new RecipeRepository();
            RefreshRecipeData();

        }

        private void listBoxRecipeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentlySelected = listBoxRecipeList.SelectedItem as Recipe;
            if(currentlySelected != null )
            {
                textBoxBoxPrice.Text = currentlySelected.GetPrice().ToString();
                textBoxBoxPersons.Text = currentlySelected.Persons.ToString();
            }
        }

        private void RefreshRecipeData()
        {
            Recipes = recRepo.GetAllRecipes();
            listBoxRecipeList.ItemsSource = Recipes;
        }











    }
}
