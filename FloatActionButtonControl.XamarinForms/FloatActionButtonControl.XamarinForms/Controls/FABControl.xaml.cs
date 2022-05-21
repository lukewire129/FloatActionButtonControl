using FloatActionButtonControl.Interface;
using FloatActionButtonControl.XamarinForms.AnimationFactory;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FloatActionButtonControl.XamarinForms.Controls
{
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class FABControl : ContentView
        {
                public static readonly BindableProperty AnimationStyleProperty = BindableProperty.Create(
                propertyName: nameof(AnimationStyle),
                returnType: typeof(string),
                declaringType: typeof(FABControl),
                defaultValue: null,
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanging: ((bindable, oldValue, newValue) =>
                {
                        Console.WriteLine("속성 변경");
                        var thisOwner = (FABControl)bindable;
                        if (ani != null)
                        {
                                var Clearani = ani.Clear();
                                if (Clearani != null)
                                {
                                        Clearani.Commit(thisOwner, "FabMainAnimation");
                                }
                        }
                        var parent = thisOwner.parent;
                        if ((string)newValue == "Scale1")
                        {
                                parent.HeightRequest = 200;
                                parent.WidthRequest = 200;                                
                                parent.SetLayoutBounds(thisOwner.FABSub1, new Rect(0, 100, -1, -1));
                                parent.SetLayoutBounds(thisOwner.FABSub2, new Rect(25, 25, -1, -1));
                                parent.SetLayoutBounds(thisOwner.FABSub3, new Rect(100, 0, -1, -1));
                                parent.SetLayoutBounds(thisOwner.FABMain, new Rect(100, 100, -1, -1));
                                ani = new Scale(thisOwner.FABSub1, thisOwner.FABSub2, thisOwner.FABSub3);
                        }
                        else if ((string)newValue == "Scale2")
                        {
                                parent.HeightRequest = 300;
                                parent.WidthRequest = 120;
                                parent.SetLayoutBounds(thisOwner.FABSub1, new Rect(20, 135, -1, -1));
                                parent.SetLayoutBounds(thisOwner.FABSub2, new Rect(20, 65, -1, -1));
                                parent.SetLayoutBounds(thisOwner.FABSub3, new Rect(20, 0, -1, -1));
                                parent.SetLayoutBounds(thisOwner.FABMain, new Rect(20, 200, -1, -1));
                                ani = new Scale(thisOwner.FABSub1, thisOwner.FABSub2, thisOwner.FABSub3);
                        }
                }));
                public string AnimationStyle
                {
                        get => (string)GetValue(AnimationStyleProperty);
                        set => SetValue(AnimationStyleProperty, value);
                }

                static IAnimation ani;
                public FABControl()
                {
                        InitializeComponent();
                }

                private void FABMain_Clicked(object sender, EventArgs e)
                {
                        ani.GetAnimation().Commit(this, "FabMainAnimation");
                }
                public delegate void ClickedHandler(object sender, EventArgs e);
                public event ClickedHandler SubButton1Clicked;
                public event ClickedHandler SubButton2Clicked;
                public event ClickedHandler SubButton3Clicked;

                private void FabSub1_Clicked(object sender, EventArgs e)
                {
                        this.SubButton1Clicked?.Invoke(sender, e);
                }

                private void FabSub2_Clicked(object sender, EventArgs e)
                {
                        this.SubButton2Clicked?.Invoke(sender, e);
                }

                private void FabSub3_Clicked(object sender, EventArgs e)
                {
                        this.SubButton3Clicked?.Invoke(sender, e);
                }
        }
}