using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurrentLocationXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoItemDetailPage : ContentPage
    {
        private TodoItem todoItem;

        public ToDoItemDetailPage()
        {
            InitializeComponent();
        }

        public ToDoItemDetailPage(TodoItem todoItem)
        {
            InitializeComponent();
            this.todoItem = todoItem;
            BindingContext = new ToDoItemDetailPageViewModel(todoItem);
        }
    }
}
