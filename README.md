# How to mask credit card number in Xamarin.Forms DataForm (SfDataForm)

You can mask the credit card number in Xamarin.Forms [SfDataForm](https://help.syncfusion.com/xamarin/dataform/getting-started?) by using [MaskedEditText](https://help.syncfusion.com/xamarin/dataform/editors?_ga=2.249620101.2045748047.1589775488-1204678185.1570168583#maskededittext-editor) editor.

Refer to the [online user guide documentation](https://help.syncfusion.com/xamarin/dataform/working-with-dataform?_ga=2.249620101.2045748047.1589775488-1204678185.1570168583#auto-generating-dataformitems-for-the-data-field) for customize the editor in DataForm using  [AutoGeneratingDataFormItem](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.SfDataForm~AutoGeneratingDataFormItem_EV.html?) event. 

You can also refer the following article.

https://www.syncfusion.com/kb/11542/how-to-mask-credit-card-number-in-xamarin-forms-dataform-sfdataform

**C#**

Customize the Mask text of [DataFormMaskedEditTextItem](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.DataFormMaskedEditTextItem.html?) in  **AutoGeneratingDataFormItem**.
``` c#
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
```
**Output**

![CreditCardNumberMask](https://github.com/SyncfusionExamples/mask-credit-card-number-dataform-xamarin/blob/master/ScreenShots/CreditCardNumberMask.gif)
