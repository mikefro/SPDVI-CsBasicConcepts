using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ToDoListApp
{
    public partial class Form1 : Form
    {

        BindingList<ToDoItem> todoList = new BindingList<ToDoItem>();
        ToDoItem currentEdit = null; 

        public Form1()
        {
            InitializeComponent();
            
            todoListBox.DataSource = todoList;
            todoListBox.DisplayMember = nameof(ToDoItem.ToDoDisplay);

        }

        private void AddTodo(string todoText)
        {
            ToDoItem todo = new ToDoItem
            {
                PositionNumber = todoList.Count + 1,
                TodoText = todoText,
            };

            todoList.Add(todo);
        }

        private void ReorderTodo()
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                todoList[i].PositionNumber = (i + 1);
            }
        }
        private void DeleteItem(ToDoItem todo)
        {
            todoList.Remove(todo);
            ReorderTodo();
        }

        private void StartEditingItem(ToDoItem todo)
        {
            currentEdit = todo;
            todoLabel.Text = "Update ToDo Item";
            addUpdateTodo.Text = "Edit ToDo Item";
            todoText.Text = currentEdit.TodoText;
        }

        private void CompleteEditingItem()
        {
            currentEdit.TodoText = todoText.Text;
            currentEdit = null;
            todoLabel.Text = "New ToDo Item";
            addUpdateTodo.Text = "Add ToDo Item";
        }

        private void CompleteItem(ToDoItem todo)
        {
            todo.IsComplete = true;
        }

        private void MoveItemUp(ToDoItem todo)
        {
            if (todo.PositionNumber == 1)
            {
                return;
            }

            todoList.Remove(todo);
            todoList.Insert(todo.PositionNumber - 2, todo);
            ReorderTodo();
        }

        private void MoveItemDown(ToDoItem todo)
        {
            if (todo.PositionNumber > todoList.Count)
            {
                return;
            }

            todoList.Remove(todo);
            todoList.Insert(todo.PositionNumber, todo);
            ReorderTodo();
        }
        private void addUpdateTodo_Click(object sender, EventArgs e)
        {
            if (currentEdit == null)
            {
                AddTodo(todoText.Text);
            }
            else
            {
                CompleteEditingItem();

            }
            todoText.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedIndex != null)
            {
                ToDoItem todo = (ToDoItem)todoListBox.SelectedItem;
                DeleteItem(todo);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedIndex != null)
            {
                ToDoItem todo = (ToDoItem)todoListBox.SelectedItem;
                StartEditingItem(todo);
            }
        }


        private void todoListBox_DoubleClick(object sender, EventArgs e)
        {
            if (todoListBox.SelectedIndex != null)
            {
                ToDoItem todo = (ToDoItem)todoListBox.SelectedItem;
                CompleteItem(todo);
            }
        }


        private void todoListBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
                case Keys.Up:
                    e.IsInputKey = true;
                    break;
                default:
                    break;
            }
        }

        private void todoListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(todoListBox.SelectedItem != null)
            {
                ToDoItem todo = (ToDoItem) todoListBox.SelectedItem;

                switch (e.KeyCode)
                {
                    case Keys.Down:
                        MoveItemDown(todo);
                        break;
                    case Keys.Up:
                        MoveItemDown(todo);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
