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
    public class Lyricsstuff : StoryboardObjectGenerator
    {   [Configurable]
        public int OutlineThickness = 3;

        [Configurable]
        public Color4 OutlineColor = new Color4(50, 50, 50, 200);

        [Configurable]
        public int ShadowThickness = 0;

        [Configurable]
        public Color4 ShadowColor = new Color4(0, 0, 0, 100);
    
        [Configurable]
        public bool enableGlow = false;

        [Configurable]
        public int glowRadius = 30;

        [Configurable]
        public Color4 glowColor = Color4.White;

        private FontGenerator font;
        public override void Generate()
        {
            font = SetFont("FOT-TsukuMinPro-D_0.otf");
            
            //Put text generations under this line
        //verse 1    
        horizontaltext ("毎朝、目を覚まして", 17481,24374, new Vector2 (320,400));
        horizontaltext ("最初に見るのが",25001,31894, new Vector2 (320,400));
        horizontaltext("あなたの無防備な",32521,39414, new Vector2 (320,400));
        horizontaltext("寝顔だなんて夢のよう",39831,47560, new Vector2 (320,400));

        horizontaltext ("あなたのために淹れる", 48186,54453, new Vector2 (320,400));
        horizontaltext ("コーヒーの香りが",55079,61972, new Vector2 (320,400));
        horizontaltext("部屋中を満たしてく",62599,69492, new Vector2 (320,400));
        horizontaltext("幸せのとき",69910,77011, new Vector2 (320,400));

        //kiai 1
        horizontaltext ("これからもずっと", 77638,91424, new Vector2 (160,400));
        horizontaltext ("一緒に暮らしていこうね", 83277,92050, new Vector2 (460,400));
        horizontaltext ("喜びも、悲しみも", 92677,99570, new Vector2 (320,400));
        horizontaltext ("半分こにしながら", 99988,108343, new Vector2 (320,400));

        //verse 2
        horizontaltext ("なんども生まれ変わり", 111894,118369, new Vector2 (320,400));
        horizontaltext ("やっと辿り着いた",119204,125888, new Vector2 (320,400));
        horizontaltext("かけがえない愛を",126515,133408, new Vector2 (320,400));
        horizontaltext("ふたり、抱きしめて",133826,141554, new Vector2 (320,400));

        //verse 3
        horizontaltext ("あなたと出逢うまでは", 158891,165366, new Vector2 (320,400));
        horizontaltext ("知らなかったキモチ",165993,172886, new Vector2 (320,400));
        horizontaltext("いとしくて、あたたかくて",173512,181032, new Vector2 (320,400));
        horizontaltext("笑顔が止まらない",181659,187925, new Vector2 (320,400));

        horizontaltext ("言葉にすればとても", 188969,195444, new Vector2 (320,400));
        horizontaltext ("ありふれてるけど",196071,202964, new Vector2 (320,400));
        horizontaltext("こんな日々のために",203591,208604, new Vector2 (320,400));
        horizontaltext("生まれてきたのかな",209230,218003, new Vector2 (320,400));


        //kiai 2
        horizontaltext ("大好きな人と結ばれて", 218630,232416, new Vector2 (220,400));
        horizontaltext ("家族になる", 227820,233042, new Vector2 (460,400));
        horizontaltext ("絆と命紡ぎ", 233669,240562, new Vector2 (320,400));
        horizontaltext ("幸せ増やしていこう", 240980,249335, new Vector2 (320,400));


        //verse 4
        horizontaltext ("手と手を握りしめて", 252886,259361, new Vector2 (320,400));
        horizontaltext ("微笑みあったら",259988,266880, new Vector2 (320,400));
        horizontaltext("果てない永遠に",267507,277533, new Vector2 (320,400));
        horizontaltext("向かって歩き出そう",277951,286512, new Vector2 (320,400));

        H1Text ("「大好きですよ。」",288707,294346, new Vector2 (320,240));

        }

        private void H1Text(string text, int startTime, int endTime, Vector2 position)
        {
            float scale = 0.5f;
            var lineWidth = 0f;
            var lineHeight = 0f;
            foreach(var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * scale;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight) * scale;
            }
            float letterX = position.X - (lineWidth/2);
            float letterY = position.Y - (lineHeight/2);
            var start = startTime;
            var end = endTime;
            foreach(var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
            
                if(!texture.IsEmpty)
                {
                    var letterPosition = new Vector2(letterX, letterY)
                        + texture.OffsetFor(OsbOrigin.Centre) * scale;

                    //Modify these next lines if you want to change the text visuals & stuff//
        

                    start +=100;
                    end +=0;

                    var sprite = GetLayer("TEXT").CreateSprite(texture.Path, OsbOrigin.Centre, letterPosition);
                    //sprite.Move(start, start+160,letterX, letterY, letterX, 260);
                    sprite.Fade(start, start+1000, 0, 1);
                    sprite.Fade(end-1000, end, 1, 0);
                    //sprite.Scale(start,start+1000,scale*0.8f,scale);
                    sprite.Scale(end-1000, end, scale, scale*0.95f);
                }
                //letterY += texture.BaseHeight * (scale*0.5f);
                letterX += texture.BaseWidth * scale;
            }
        }

        private FontGenerator SetFont(string fontName)
        {
            return LoadFont("sb/lyrics", new FontDescription{
                FontPath = fontName,
                FontSize = 54,
                Color = Color4.White,
            },
            new FontOutline()
            {
                Thickness = OutlineThickness,
                Color = OutlineColor,
            },
            new FontGlow()
            {
                Radius = !enableGlow ? 0 : glowRadius,
                Color = glowColor,
            },
            new FontShadow()
            {
                Thickness = ShadowThickness,
                Color = ShadowColor,
            });
        }

        private void horizontaltext(string text, int startTime, int endTime, Vector2 position)
        {
            float scale = 0.4f;
            var lineWidth = 0f;
            var lineHeight = 0f;
            foreach(var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * scale;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight) * scale;
            }
            float letterX = position.X - (lineWidth/2);
            float letterY = position.Y - (lineHeight/2);
            var start = startTime;
            var end = endTime;
            foreach(var letter in text)
            {
                var texture = font.GetTexture(letter.ToString());
            
                if(!texture.IsEmpty)
                {
                    var letterPosition = new Vector2(letterX, letterY)
                        + texture.OffsetFor(OsbOrigin.Centre) * scale;

                    //Modify these next lines if you want to change the text visuals & stuff//
        

                    start +=80;
                    end +=80;

                    var sprite = GetLayer("TEXT").CreateSprite(texture.Path, OsbOrigin.Centre, letterPosition);
                    sprite.Fade(start, start+200, 0, 1);
                    sprite.Fade(end-200, end, 1, 0);
                    sprite.Scale(start,start+200,scale*0.9f,scale);
                    sprite.Scale(end-200, end, scale, scale*0.9f);
                }
                //letterY += texture.BaseHeight * (scale*0.5f);
                letterX += texture.BaseWidth * scale;
            }
        }


    }
}
