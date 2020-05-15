using Syncfusion.XForms.ComboBox;
using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataFormXamarin
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
        }
        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.Name == "CardNumber")
                {
                    var maskedItem = e.DataFormItem as DataFormMaskedEditTextItem;
                    maskedItem.Mask = "0000-0000-0000-0000";
                    maskedItem.PromptChar = 'X';
                    maskedItem.KeyBoard = Keyboard.Numeric;
                }
            }
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            dataForm.AutoGeneratingDataFormItem -= DataForm_AutoGeneratingDataFormItem;
        }
    }
}