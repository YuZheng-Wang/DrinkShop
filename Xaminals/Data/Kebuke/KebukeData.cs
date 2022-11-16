using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class KebukeData
    {
        public static IList<Drink> Kebuke { get; private set; }

        static KebukeData()
        {
            Kebuke = new List<Drink>();

            Kebuke.Add(new Drink
            {
                Name = "熟成紅茶",
                Introduction = "解炸物/燒烤肉類油膩，茶味濃郁帶果香",
                Price = "M 30 / L 35",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/01-S%E7%86%9F%E6%88%90%E7%B4%85%E8%8C%B6-1.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "麗春紅茶",
                Introduction = "去除海鮮羶腥，茶味較淡帶花香",
                Price = "M 30 / L 35",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2020/12/%E8%83%AD%E8%84%82%E7%B4%85%E8%8C%B6-1.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "太妃紅茶",
                Introduction = "咖啡與茶的神祕比例搭配",
                Price = "M 35 / L 40",
                SizeM = "35",
                SizeL = "40",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/03-S%E5%A4%AA%E5%A6%83%E7%B4%85%E8%8C%B6-1.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "胭脂紅茶",
                Introduction = "絲絨般的蜜桃果香",
                Price = "M 40 / L 45",
                SizeM = "40",
                SizeL = "45",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2020/12/%E9%BA%97%E6%98%A5%E7%B4%85%E8%8C%B6-1.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "雪藏紅茶",
                Introduction = "冰淇淋與紅茶的綿綿情意",
                Price = "M 50 / L 60",
                SizeM = "50",
                SizeL = "60",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/11-S%E9%9B%AA%E8%97%8F%E7%B4%85%E8%8C%B6.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "熟成冷露",
                Introduction = "手工冬瓜與茶更神秘比例搭配",
                Price = "M 30 / L 35",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/07-S%E7%86%9F%E6%88%90%E5%86%B7%E9%9C%B2.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "雪花冷露",
                Introduction = "手工冬瓜獨奏",
                Price = "M 30 / L 35",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/06-S%E9%9B%AA%E8%8A%B1%E5%86%B7%E9%9C%B2.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "春芽冷露",
                Introduction = "手工冬瓜綠茶",
                Price = "M 30 / L 35",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/08-S%E6%98%A5%E8%8A%BD%E5%86%B7%E9%9C%B2.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "春芽綠茶",
                Introduction = "綠茶，糸糸中帶點彔彔",
                Price = "M 30 / L 35 ",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/05-S%E6%98%A5%E8%8A%BD%E7%B6%A0%E8%8C%B6.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "春梅冰茶",
                Introduction = "春梅玉冬瓜相遇",
                Price = "M 40 / L 50",
                SizeM = "40",
                SizeL = "50",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/09-S%E6%98%A5%E6%A2%85%E5%86%B0%E8%8C%B6.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "冷露歐蕾",
                Introduction = "手工冬瓜與鮮奶",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/12-S%E5%86%B7%E9%9C%B2%E6%AD%90%E8%95%BE.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "熟成歐蕾",
                Introduction = "熟成鮮奶茶",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/13-S%E7%86%9F%E6%88%90%E6%AD%90%E8%95%BE.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "白玉歐蕾",
                Introduction = "珍奶不解釋",
                Price = "M 55 / L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/14-S%E7%99%BD%E7%8E%89%E6%AD%90%E8%95%BE.jpg"

            });

            Kebuke.Add(new Drink
            {
                Name = "熟成檸果",
                Introduction = "每日限量鮮檸紅茶",
                Price = "M 55",
                SizeM = "55",
                SizeL = "0",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/10-S%E7%86%9F%E6%88%90%E6%AA%B8%E6%9E%9C.jpg"
            });

            Kebuke.Add(new Drink
            {
                Name = "胭脂多多",
                Introduction = "蜜桃裡的兒時記憶",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/202012-1-S%E8%83%AD%E8%84%82%E5%A4%9A%E5%A4%9A.jpg"
            });

        }
    }
}
