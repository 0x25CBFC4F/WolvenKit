using System;
using System.Windows;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Converters;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels;

namespace WolvenKit.Views.Templates
{
    /// <summary>
    /// Interaction logic for RedCollectionEditor.xaml
    /// </summary>
    public partial class RedCollectionEditor
    {
        private readonly IRedArray _redarray;

        public RedCollectionEditor(IRedArray redarray)
        {
            InitializeComponent();

            _redarray = redarray;

            if (DataContext is RedCollectionEditorViewModel vm)
            {
                vm.SetElements(_redarray);
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void PropertyGrid_AutoGeneratingPropertyGridItem(object sender, Syncfusion.Windows.PropertyGrid.AutoGeneratingPropertyGridItemEventArgs e)
        {
            if (e.OriginalSource is PropertyItem { } propertyItem)
            {
                if (DataContext is RedCollectionEditorViewModel viewModel)
                {
                    var propertyType = propertyItem.PropertyType;
                    var propertyName = propertyItem.DisplayName;

                    ITypeEditor customEditor = null;

                    if (propertyType == typeof(object) && propertyName.Equals("Element"))
                    {
                        var type = viewModel.SelectedElement.Element.GetType();
                        customEditor = PropertyGridEditors.GetPropertyEditor(type);
                    }
                    else
                    {
                        customEditor = PropertyGridEditors.GetPropertyEditor(propertyItem.PropertyType);
                    }

                    if (customEditor is not null)
                    {
                        propertyItem.Editor = customEditor;
                        e.ExpandMode = PropertyExpandModes.FlatMode;
                    }

                }


            }
        }

        private void PropertyGrid_CollectionEditorOpening(object sender, CollectionEditorOpeningEventArgs e)
        {
            //Restrict collection editor window opening
            e.Cancel = true;

            if (sender is PropertyGrid pg)
            {
                var selectedProperty = pg.SelectedPropertyItem;
                var prop = selectedProperty.Value;

                if (prop is IRedArray editableVariable)
                {
                    // open custom collection editor
                    var collectionEditor = new RedCollectionEditor(editableVariable);
                    var r = collectionEditor.ShowDialog();
                    if (r ?? true)
                    {
                        //TODO
                    }
                }
                else
                {
                    throw new ArgumentException(nameof(editableVariable));
                }
            }
        }
    }
}
