using FloatActionButtonControl.Interface;

namespace FloatActionButtonControl.AnimationFactory
{
        public class Scale: _ani, IAnimation
        {
                public Scale(View subControl1, View subControl2, View subControl3)
                        :base(subControl1, subControl2, subControl3)
                {

                }

                public Animation GetAnimation()
                {
                        var animation = new Animation();
                        if (sub1.Scale != 0)
                        {
                                var FabSub1Animation = new Animation(v => sub1.Scale = v, 1, 0, Easing.SpringIn);
                                var FabSub2Animation = new Animation(v => sub2.Scale = v, 1, 0, Easing.SpringIn);
                                var FabSub3Animation = new Animation(v => sub3.Scale = v, 1, 0, Easing.SpringIn);


                                animation.Add(0, 0.3, FabSub3Animation);
                                animation.Add(0.3, 0.6, FabSub2Animation);
                                animation.Add(0.6, 1, FabSub1Animation);
                        }
                        else
                        {
                                var FabSub1Animation = new Animation(v => sub1.Scale = v, 0, 1, Easing.SpringIn);
                                var FabSub2Animation = new Animation(v => sub2.Scale = v, 0, 1, Easing.SpringIn);
                                var FabSub3Animation = new Animation(v => sub3.Scale = v, 0, 1, Easing.SpringIn);


                                animation.Add(0, 0.3, FabSub1Animation);
                                animation.Add(0.3, 0.6, FabSub2Animation);
                                animation.Add(0.6, 1, FabSub3Animation);
                        }

                        return animation;
                }

                public Animation Clear()
                {
                        Animation animation = null;
                        if (sub1.Scale != 0)
                        {
                                animation = new Animation();
                                var FabSub1Animation = new Animation(v => sub1.Scale = v, 1, 0, Easing.SpringIn);
                                var FabSub2Animation = new Animation(v => sub2.Scale = v, 1, 0, Easing.SpringIn);
                                var FabSub3Animation = new Animation(v => sub3.Scale = v, 1, 0, Easing.SpringIn);


                                animation.Add(0, 0.3, FabSub3Animation);
                                animation.Add(0.3, 0.6, FabSub2Animation);
                                animation.Add(0.6, 1, FabSub1Animation);
                        }

                        return animation;
                }
        }
}
