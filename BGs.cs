using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class BGs : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		BG ("sb/bgblur/1.jpg", 574,294346);
        Boxes1();
        Boxes2();
        BackgroundsPt1();
        BackgroundsPt2();
        Kanna();
        EDCg();

        var layer = GetLayer("");
        var metadata = layer.CreateSprite("sb/metadata.png", OsbOrigin.Centre, new Vector2 (320,220));
        var mapper = layer.CreateSprite("sb/mapper.png", OsbOrigin.CentreLeft, new Vector2 (64,380));
        var storyboarder = layer.CreateSprite("sb/storyboarder.png", OsbOrigin.CentreLeft, new Vector2 (64,412));
        var game = layer.CreateSprite("sb/game.png");

        metadata.Fade(10588,11215,0,1);
        metadata.Scale(10588, 480.0/1280);
        metadata.Fade(13722,14348,1,0);

        mapper.Fade(14348,14975,0,1);
        mapper.Scale(14348, 480.0/1440);
        mapper.Fade(16228,16855,1,0);

        storyboarder.Fade(14348,14975,0,1);
        storyboarder.Scale(14348, 480.0/1440);
        storyboarder.Fade(16228,16855,1,0);

        game.Fade(574,1198,0,1);
        game.Scale(574,10588,0.65,0.55);
        game.Fade(9341,9965,1,0);
        }

        private void BackgroundsPt1()
        {
            var blank = GetLayer("a").CreateSprite("sb/cg/blank.png", OsbOrigin.Centre, new Vector2(320, 200));
            var bg = GetLayer("a").CreateSprite("sb/cg/11.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg2 = GetLayer("a").CreateSprite("sb/cg/12.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg3 = GetLayer("a").CreateSprite("sb/cg/13.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg4 = GetLayer("a").CreateSprite("sb/cg/14.jpg", OsbOrigin.Centre, new Vector2(320, 200));

            var bg5 = GetLayer("a").CreateSprite("sb/cg/21.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg6 = GetLayer("a").CreateSprite("sb/cg/22.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg7 = GetLayer("a").CreateSprite("sb/cg/23.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg8 = GetLayer("a").CreateSprite("sb/cg/24.jpg", OsbOrigin.Centre, new Vector2(320, 200));

            var bg9 = GetLayer("a").CreateSprite("sb/cg/31.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg10 = GetLayer("a").CreateSprite("sb/cg/32.jpg", OsbOrigin.Centre, new Vector2(320, 200));

            var bg11 = GetLayer("a").CreateSprite("sb/cg/41.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg12 = GetLayer("a").CreateSprite("sb/cg/42.jpg", OsbOrigin.Centre, new Vector2(320, 200));

            var bg13 = GetLayer("a").CreateSprite("sb/cg/51.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg14 = GetLayer("a").CreateSprite("sb/cg/52.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg15 = GetLayer("a").CreateSprite("sb/cg/53.jpg", OsbOrigin.Centre, new Vector2(320, 200));

            bg.Fade(17481, 0);
            bg.Scale(17481, (480.0f / 1080) * 0.9f);
            bg2.Scale(17481, (480.0f / 1080) * 0.9f);
            bg3.Scale(17481, (480.0f / 1080) * 0.9f);
            bg4.Scale(17481, (480.0f / 1080) * 0.9f);
            bg5.Scale(17481, (480.0f / 1080) * 0.9f);
            bg6.Scale(17481, (480.0f / 1080) * 0.9f);
            bg7.Scale(17481, (480.0f / 1080) * 0.9f);
            bg8.Scale(17481, (480.0f / 1080) * 0.9f);
            bg9.Scale(17481, (480.0f / 1080) * 0.9f);
            bg10.Scale(17481, (480.0f / 1080) * 0.9f);
            bg11.Scale(17481, (480.0f / 1080) * 0.9f);
            bg12.Scale(17481, (480.0f / 1080) * 0.9f);
            bg13.Scale(17481, (480.0f / 1080) * 0.9f);
            bg14.Scale(17481, (480.0f / 1080) * 0.9f);
            bg15.Scale(17481, (480.0f / 1080) * 0.9f);

            blank.Scale(0, (480.0f / 1080) * 0.94f);


            bg.Fade(17481, 18108, 0,1);
            bg2.Fade(25001, 25628, 0,1);
            bg3.Fade(32521, 33147, 0,1);
            bg4.Fade(40040, 40667, 0,1);

            bg5.Fade(48186, 48813, 0,1);
            bg6.Fade(55079, 55706, 0,1);
            bg7.Fade(63226, 63852, 0,1);
            bg8.Fade(70745, 71372, 0,1);

            bg9.Fade(78264, 78891, 0,1);
            bg10.Fade(93303, 93930, 0,1);

            bg11.Fade(112102, 112729, 0,1);
            bg12.Fade(119622, 120249, 0,1);
            
            bg13.Fade(127142, 127768, 0,1);
            bg14.Fade(134661, 135288, 0,1);
            bg15.Fade(138421, 140301, 0,1);


            
            blank.Fade(17481,18108,0,1);

            int randDuration = Random(1000,3000);
            var prevPosY = 200;
            var prevRotate = 0f;
            for (int time = 17481;  time < 142181; time += randDuration)
            {
                randDuration = Random(1000,3000);
                int nextPosY = prevPosY + Random(-10, 10);
                float nextRotate = prevRotate + Random (-0.05f, 0.05f);

                if (nextPosY > 220 | nextPosY < 180)
                {
                    nextPosY = 200;
                    bg.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg3.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg4.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    blank.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg5.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg6.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg7.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg8.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg9.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg10.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg11.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg12.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg13.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg14.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg15.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }
                else
                {
                    bg.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg3.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg4.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    blank.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg5.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg6.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg7.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg8.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg9.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg10.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg11.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg12.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg13.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg14.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg15.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }

                if (nextRotate > 0.06 | nextRotate < -0.06)
                {   
                    nextRotate = 0;
                    bg.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg3.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg4.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    blank.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg5.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg6.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg7.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg8.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg9.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg10.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg11.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg12.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg13.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg14.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg15.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                else
                {
                    bg.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg3.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg4.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    blank.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg5.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg6.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg7.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg8.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg9.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg10.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg11.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg12.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg13.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg14.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg15.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                prevPosY = nextPosY;
                prevRotate = nextRotate;
            }
            bg.Fade(26254, 0);
            bg2.Fade(33774, 0);
            bg3.Fade(41293, 0);
            bg4.Fade(46307,47560, 1,0);
            
            bg5.Fade(63852,0);
            bg6.Fade(71372,0);
            bg7.Fade(71372,0);
            bg8.Fade(74504,77011,1,0);

            bg9.Fade(93930,0);
            bg10.Fade(104583,108343,1,0);

            bg11.Fade(120249,0);
            bg12.Fade(125262,126515,1,0);

            bg13.Fade(135288,0);
            bg14.Fade(140301,0);
            bg15.Fade(141554,142181,1,0);

            blank.Fade (141554,142181,1,0);

        }

        private void Kanna()
        {
            var border1 = GetLayer("KannaSD").CreateSprite("sb/SDCG/border.png", OsbOrigin.Centre, new Vector2(0,600));
            var border2 = GetLayer("KannaSD").CreateSprite("sb/SDCG/border.png", OsbOrigin.Centre, new Vector2(270,600));
            var border3 = GetLayer("KannaSD").CreateSprite("sb/SDCG/border.png", OsbOrigin.Centre, new Vector2(385,600));
            var border4 = GetLayer("KannaSD").CreateSprite("sb/SDCG/border.png", OsbOrigin.Centre, new Vector2(120,600));

            var sd1 = GetLayer("KannaSD").CreateSprite("sb/SDCG/1.png", OsbOrigin.Centre, new Vector2(0, 600));
            var sd2 = GetLayer("KannaSD").CreateSprite("sb/SDCG/2.png", OsbOrigin.Centre, new Vector2(270,600));
            var sd3 = GetLayer("KannaSD").CreateSprite("sb/SDCG/3.png", OsbOrigin.Centre, new Vector2(385,600));
            var sd4 = GetLayer("KannaSD").CreateSprite("sb/SDCG/4.png", OsbOrigin.Centre, new Vector2(120,600));

            var kannasil = GetLayer("KannaSD").CreateSprite("sb/kannasprite_sil.png", OsbOrigin.Centre, new Vector2(600, 600));
            var kanna = GetLayer("KannaSD").CreateSprite("sb/kannasprite.png", OsbOrigin.Centre, new Vector2(600, 600));

            
            

            sd1.MoveY(142181,155967,600,-150);
            sd1.Scale(142181,0.2);
            sd2.MoveY(151580,159726,600,-150);
            sd2.Scale(142181,0.28);
            sd3.MoveY(146567,159100,600,-150);
            sd3.Scale(142181,0.2);
            sd4.MoveY(149700,157220,600,-150);
            sd4.Scale(142181,0.32);

            sd1.Fade(142181,144061,0,1);
            sd2.Fade(151580,153460,0,1);
            sd3.Fade(146567,145941,0,1);
            sd4.Fade(149700,151580,0,1);

            border1.MoveY(142181,155967,600,-150);
            border1.Scale(142181,0.2);
            border2.MoveY(151580,159726,600,-150);
            border2.Scale(142181,0.28);
            border3.MoveY(146567,159100,600,-150);
            border3.Scale(142181,0.2);
            border4.MoveY(149700,157220,600,-150);
            border4.Scale(142181,0.32);

            border1.Fade(142181,144061,0,1);
            border2.Fade(151580,153460,0,1);
            border3.Fade(146567,145941,0,1);
            border4.Fade(149700,151580,0,1);


            border1.Rotate(142181,162860,0,MathHelper.DegreesToRadians(-180));
            border2.Rotate(142181,162860,0,MathHelper.DegreesToRadians(-180));
            border3.Rotate(142181,162860,0,MathHelper.DegreesToRadians(-180));
            border4.Rotate(142181,162860,0,MathHelper.DegreesToRadians(-180));

            kanna.Fade(142181,144061,0,1);
            kanna.Scale(142181,0.6);
            kanna.Fade(157220,159100,1,0);
            kannasil.Fade(142181,145941,0,1);
            kannasil.Scale(142181,0.62);
            kannasil.Fade(157220,159100,1,0);


            int randDuration = Random(1000,3000);
            
            var prevPosY = 600;
            var prevRotate = 0f;
            for (int time = 142181;  time < 159100; time += randDuration)
            {
                randDuration = Random(1000,3000);
                int nextPosY = prevPosY + Random(-25, 15);
                float nextRotate = prevRotate + Random (-0.05f, 0.05f);

                if (nextPosY > 640 | nextPosY < 560)
                {
                    nextPosY = 600;
                    kanna.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    kannasil.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }
                else
                {
                    kanna.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    kannasil.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }

                if (nextRotate > 0.06 | nextRotate < -0.06)
                {   
                    nextRotate = 0;
                    kanna.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    kannasil.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                else
                {
                    kanna.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    kannasil.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                prevPosY = nextPosY;
                prevRotate = nextRotate;
            }
        }

        private void Boxes1()
        {
            var box1 = GetLayer("").CreateSprite("sb/cg/blank2.png", OsbOrigin.Centre, new Vector2(320, 200));

            var sus = new Color4(210,187,173, 100);

            box1.Fade(18746,19361,0,1);
            box1.Scale(17481,0.46);

            box1.Fade(159726,160353,0,1);

            box1.Color(17481,sus);
            int randDuration = Random(4000,6000);
            
            var prevPosY = 200;
            var prevRotate = 0f;
            for (int time = 17481;  time < 142181; time += randDuration)
            {
                randDuration = Random(4000,6000);
                int nextPosY = prevPosY + Random(-10, 10);
                float nextRotate = prevRotate + Random (-0.05f, 0.05f);

                if (nextPosY > 190 | nextPosY < 210)
                {
                    nextPosY = 200;
                    box1.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }
                else
                {
                    box1.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }

                if (nextRotate > 0.07 | nextRotate < -0.07)
                {   
                    nextRotate = 0;
                    box1.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                else
                {
                    box1.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                prevPosY = nextPosY;
                prevRotate = nextRotate;
            }
            for (int time = 158473;  time < 280859; time += randDuration)
            {
                randDuration = Random(4000,6000);
                int nextPosY = prevPosY + Random(-10, 10);
                float nextRotate = prevRotate + Random (-0.05f, 0.05f);

                if (nextPosY > 190 | nextPosY < 210)
                {
                    nextPosY = 200;
                    box1.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }
                else
                {
                    box1.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }

                if (nextRotate > 0.07 | nextRotate < -0.07)
                {   
                    nextRotate = 0;
                    box1.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                else
                {
                    box1.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                prevPosY = nextPosY;
                prevRotate = nextRotate;
            }
            box1.Fade(141554,142181,1,0);
            box1.Fade(280859,281918,1,0);
        }

        private void Boxes2()
        {
            var box2 = GetLayer("a").CreateSprite("sb/cg/blank2.png", OsbOrigin.Centre, new Vector2(320, 200));

            var sus2 = new Color4(248,226,212, 100);

            box2.Fade(18108,18735,0,1);
            box2.Scale(17481,0.44);

            box2.Fade(159100,159726,0,1);

            box2.Color(17481,sus2);

            int randDuration = Random(6000,8000);
            
            var prevPosY = 200;
            var prevRotate = 0f;
            for (int time = 17481;  time < 142181; time += randDuration)
            {
                randDuration = Random(6000,8000);
                int nextPosY = prevPosY + Random(-10, 10);
                float nextRotate = prevRotate + Random (-0.05f, 0.05f);

                if (nextPosY > 220 | nextPosY < 170)
                {
                    nextPosY = 200;
                    box2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }
                else
                {
                    box2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }

                if (nextRotate > 0.07 | nextRotate < -0.07)
                {   
                    nextRotate = 0;
                    box2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                else
                {
                    box2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                prevPosY = nextPosY;
                prevRotate = nextRotate;
            }
            for (int time = 158473;  time < 280859; time += randDuration)
            {
                randDuration = Random(6000,8000);
                int nextPosY = prevPosY + Random(-10, 10);
                float nextRotate = prevRotate + Random (-0.05f, 0.05f);

                if (nextPosY > 220 | nextPosY < 170)
                {
                    nextPosY = 200;
                    box2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }
                else
                {
                    box2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }

                if (nextRotate > 0.07 | nextRotate < -0.07)
                {   
                    nextRotate = 0;
                    box2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                else
                {
                    box2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                prevPosY = nextPosY;
                prevRotate = nextRotate;
            }
            box2.Fade(141554,142181,1,0);
            box2.Fade(280859,281918,1,0);
        }

        private void BackgroundsPt2()
        {
            var blank2 = GetLayer("b").CreateSprite("sb/cg/blank.png", OsbOrigin.Centre, new Vector2(320, 200));
            var bg = GetLayer("b").CreateSprite("sb/cg/61.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg2 = GetLayer("b").CreateSprite("sb/cg/62.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg3 = GetLayer("b").CreateSprite("sb/cg/63.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg4 = GetLayer("b").CreateSprite("sb/cg/64.jpg", OsbOrigin.Centre, new Vector2(320, 200));

            var bg5 = GetLayer("b").CreateSprite("sb/cg/71.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg6 = GetLayer("b").CreateSprite("sb/cg/72.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg7 = GetLayer("b").CreateSprite("sb/cg/73.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg8 = GetLayer("b").CreateSprite("sb/cg/74.jpg", OsbOrigin.Centre, new Vector2(320, 200));

            var bg9 = GetLayer("b").CreateSprite("sb/cg/81.jpg", OsbOrigin.Centre, new Vector2(320, 200));

            var bg10 = GetLayer("b").CreateSprite("sb/cg/91.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg11 = GetLayer("b").CreateSprite("sb/cg/92.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg12 = GetLayer("b").CreateSprite("sb/cg/93.jpg", OsbOrigin.Centre, new Vector2(320, 200));
            var bg13 = GetLayer("b").CreateSprite("sb/cg/94.jpg", OsbOrigin.Centre, new Vector2(320, 200));


            bg.Fade(17481, 0);
            bg.Scale(17481, (480.0f / 1080) * 0.9f);
            bg2.Scale(17481, (480.0f / 1080) * 0.9f);
            bg3.Scale(17481, (480.0f / 1080) * 0.9f);
            bg4.Scale(17481, (480.0f / 1080) * 0.9f);
            bg5.Scale(17481, (480.0f / 1080) * 0.9f);
            bg6.Scale(17481, (480.0f / 1080) * 0.9f);
            bg7.Scale(17481, (480.0f / 1080) * 0.9f);
            bg8.Scale(17481, (480.0f / 1080) * 0.9f);
            bg9.Scale(17481, (480.0f / 1080) * 0.9f);
            bg10.Scale(17481, (480.0f / 1080) * 0.9f);
            bg11.Scale(17481, (480.0f / 1080) * 0.9f);
            bg12.Scale(17481, (480.0f / 1080) * 0.9f);
            bg13.Scale(17481, (480.0f / 1080) * 0.9f);

            blank2.Scale(0, (480.0f / 1080) * 0.94f);


            bg.Fade(158473, 159100, 0,1);
            bg2.Fade(165993, 166619, 0,1);
            bg3.Fade(173512, 174139, 0,1);
            bg4.Fade(181032, 181659, 0,1);

            bg5.Fade(189178, 189805, 0,1);
            bg6.Fade(196698, 197324, 0,1);
            bg7.Fade(204217, 204844, 0,1);
            bg8.Fade(211737, 212364, 0,1);

            bg9.Fade(219256, 219883, 0,1);

            bg10.Fade(253095, 253721, 0,1);
            bg11.Fade(259988, 260614, 0,1);
            bg12.Fade(271894, 275653, 0,1);
            bg13.Fade(278980, 279606, 0,1);

            blank2.Fade(158473,159100,0,1);

            int randDuration = Random(1000,3000);
            
            var prevPosY = 200;
            var prevRotate = 0f;
            for (int time = 158473;  time < 282752; time += randDuration)
            {
                randDuration = Random(1000,3000);
                int nextPosY = prevPosY + Random(-10, 10);
                float nextRotate = prevRotate + Random (-0.05f, 0.05f);

                if (nextPosY > 220 | nextPosY < 180)
                {
                    nextPosY = 200;
                    bg.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg3.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg4.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    blank2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg5.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg6.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg7.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg8.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg9.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg10.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg11.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg12.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg13.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }
                else
                {
                    bg.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg3.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg4.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    blank2.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg5.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg6.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg7.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg8.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg9.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg10.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg11.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg12.MoveY(time, time + randDuration, prevPosY, nextPosY);
                    bg13.MoveY(time, time + randDuration, prevPosY, nextPosY);
                }

                if (nextRotate > 0.06 | nextRotate < -0.06)
                {   
                    nextRotate = 0;
                    bg.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg3.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg4.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    blank2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg5.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg6.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg7.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg8.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg9.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg10.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg11.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg12.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg13.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                else
                {
                    bg.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg3.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg4.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    blank2.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg5.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg6.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg7.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg8.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg9.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg10.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg11.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg12.Rotate(time, time + randDuration, prevRotate, nextRotate);
                    bg13.Rotate(time, time + randDuration, prevRotate, nextRotate);
                }

                prevPosY = nextPosY;
                prevRotate = nextRotate;
            }
            bg.Fade(167246, 0);
            bg2.Fade(174766, 0);
            bg3.Fade(182285, 0);
            bg4.Fade(185418,189178,1,0);
            
            bg5.Fade(197324,0);
            bg6.Fade(204844,0);
            bg7.Fade(212364,0);
            bg8.Fade(215497,217377,1,0);

            bg9.Fade(245575,249335,1,0);

            bg10.Fade(261241,0);
            bg11.Fade(275653,0);
            bg12.Fade(279606,0);
            bg13.Fade(280859,281918,1,0);

            blank2.Fade (280859,281918,1,0);

        }

    private void EDCg()
    {var layer = GetLayer("MainBackground");

    var sprite1 = layer.CreateSprite("sb/CG/ED1.jpg",OsbOrigin.Centre);
    var sprite2 = layer.CreateSprite("sb/CG/ED2.jpg",OsbOrigin.Centre);
    var test = layer.CreateSprite("sb/test.png",OsbOrigin.Centre, new Vector2(320,400));
    
    sprite1.Fade(282752,284632,0,1);
    sprite1.Fade(286512,0);
    sprite1.Scale(282752,292466,0.47,480.0f/1080);
    sprite2.Scale(282752,292466,0.47,480.0f/1080);
    sprite2.Fade(285886,286512,0,1);
    sprite2.Fade(286512,288707,1,0);

    test.ScaleVec(282752,0.55,0.4);
    test.ScaleVec(OsbEasing.OutCubic,287175,288707,0.55,0.4,0,0.4);
    test.Fade(282752,284632,0,0.3);
    test.Fade(286512,288707,0.3,0);
    } 

    private void BG (string filename, int startTime, int endTime)
    {
    var layer = GetLayer("MainBackground");

    var sprite = layer.CreateSprite(filename,OsbOrigin.Centre);

    sprite.Fade(startTime,startTime+500,0,1);
    sprite.Fade(endTime,endTime+500,1,0);
    sprite.Scale(startTime, 480.0/720);
    }     
    }
}
