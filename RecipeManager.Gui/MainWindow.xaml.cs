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
        List<Ingredient> Ingredients;
        List<Ingredient> RecipeIngredients;
        Recipe currentRecipe;


        public MainWindow()
        {
            InitializeComponent();
            ingRepo = new IngredientRepository();
            recRepo = new RecipeRepository();
            RefreshRecipeData();
            RefreshIngredientData();
            RecipeIngredients = new List<Ingredient>(0);

        }

        private void listBoxRecipeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentRecipe = listBoxRecipeList.SelectedItem as Recipe;
            if(currentRecipe != null )
            {
                textBoxBoxPrice.Text = currentRecipe.GetPrice().ToString();
                textBoxBoxPersons.Text = currentRecipe.Persons.ToString();
                dataGridIngredientsInSelectedRecipe.ItemsSource = currentRecipe.Ingredients;
            }
        }
        
        private void buttonMoveItemRight_Click(object sender, RoutedEventArgs e)
        {
            Ingredient ing = dataGridAllIngredients.SelectedItem as Ingredient;

            if( ing != null )
            {
                (bool exists, int x) = IngredientListCheck(RecipeIngredients, ing);
                if( !exists )
                {
                    RecipeIngredients.Add(ing);
                }
                else
                {
                    MessageBox.Show("Ingredients can only appear once per recipe.", "The ingredient has already been added.", MessageBoxButton.OK, MessageBoxImage.Information);
                } 
            }
            RefreshRecipeIngredientData();
        }

        private void buttonMoveItemLeft_Click(object sender, RoutedEventArgs e)
        {
            Ingredient ing = dataGridItemsInNewRecipe.SelectedItem as Ingredient;

            if( ing != null )
            {
                (bool exists, int x) = IngredientListCheck(RecipeIngredients, ing);
                if( exists )
                {
                    RecipeIngredients.Remove(ing);
                }
                else
                {
                    MessageBox.Show("the ingredient is not in the recipe", "the ingredient is not in the recipe", MessageBoxButton.OK, MessageBoxImage.Information);
                } 
            }
            RefreshRecipeIngredientData();
        }

        private void RefreshRecipeData()
        {
            Recipes = recRepo.GetAllRecipes();
            listBoxRecipeList.ItemsSource = Recipes;
        }

        private void RefreshIngredientData()
        {
            Ingredients = ingRepo.GetAllIngredients();
            dataGridAllIngredients.ItemsSource = Ingredients;
        }

        private void RefreshRecipeIngredientData()
        {
            dataGridItemsInNewRecipe.ItemsSource = (null);
            dataGridItemsInNewRecipe.ItemsSource = (RecipeIngredients);
        }

        private (bool, int) IngredientListCheck(List<Ingredient> ingList, Ingredient ingredient)
        {
            bool exists = false;
            int Id = -1;
            for(int i = 0; i < ingList.Count; i++)
            {
                if(ingList[i].Name == ingredient.Name )
                {
                    exists = true;
                    Id = i;
                }
            }
            return (exists, Id);
        }
        
    }
}
