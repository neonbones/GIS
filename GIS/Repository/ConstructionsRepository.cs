using GIS.Finder;
using System.Collections.Generic;

namespace GIS.Repository
{
    public class ConstructionsRepository
    {
        private List<MousePoint> Warthmith = new List<MousePoint>
        {
            new MousePoint(149,219),
            new MousePoint(117,193),
            new MousePoint(173,137),
            new MousePoint(204,166),
        };

        private List<MousePoint> FaendalsHouse = new List<MousePoint>
        {
            new MousePoint(172,341),
            new MousePoint(169,375),
            new MousePoint(218,378),
            new MousePoint(219,344),
        };

        private List<MousePoint> GerdursHouse = new List<MousePoint>
        {
            new MousePoint(231,318),
            new MousePoint(257,289),
            new MousePoint(277,307),
            new MousePoint(306,278),
            new MousePoint(333,299),
            new MousePoint(279,359),
        };

        private List<MousePoint> RiverwoodTrader = new List<MousePoint>
        {
            new MousePoint(215,253),
            new MousePoint(191,229),
            new MousePoint(220,199),
            new MousePoint(243,223),
        };
        
        private List<MousePoint> SleepingGiantInn = new List<MousePoint>
        {
            new MousePoint(292,211),
            new MousePoint(258,180),
            new MousePoint(320,107),
            new MousePoint(353,135),
           
        };

        private List<MousePoint> SvensHouse = new List<MousePoint>
        {
            new MousePoint(141,297),
            new MousePoint(122,269),
            new MousePoint(174,237),
            new MousePoint(188,268),
        };

        // Warthmith
        public List<MousePoint> GetWarthmith()
        {
            return Warthmith;
        }

        public string GetWarthmithDescription()
        {
            return "Название:\nДом Алвора и Сигрид.\n\n" +
                "Описание:\nЭто довольно большой и красивый дом в деревне Ривервуд. К зданию слева пристроена крытая кузница, в которой находится наковальня, верстак, точильный камень и дубильный станок, однако отсутствует плавильня." +
                "\n\nПерсонажи:\nАлвор, Сигрид, Дорти, Хадвар."+
                "\n\nКвесты:\n«Перед бурей» — одна из ключевых локаций квеста.\n«Обучение кузнечному делу» — местонахождение квестодателя.";
        }

        // FaendalsHouse
        public List<MousePoint> GetFaendalsHouse()
        {
            return FaendalsHouse;
        }
        public string GetFaendalsHouseDescription()
        {
            return "Название:\nДом Фендала.\n\n" +
                "Описание:\nТипичный нордский дом с небольшим ограждением впереди, расположенный в деревеньке Ривервуд. Также к дому пристроена небольшая открытая веранда, на которой справа и слева от входа расположены небольшие поленицы дров, а также одна бочка." +
                "\n\nПерсонажи:\nФендал."+
                "\n\nКвесты:\n«Письмо Камилле Валерии» — возможное местонахождение одного из квестодателей.";
        }
        // GerdursHouse
        public List<MousePoint> GetGerdursHouse()
        {
            return GerdursHouse;
        }
        public string GetGerdursHouseDescription()
        {
            return "Название:\nДом Хода и Гердур.\n\n" +
                "Описание:\nЭтот небольшой дом, построенный в традиционном нордском стиле, расположен в Ривервуде, возле восточного входа. Дом довольно большого размера и частично огорожен забором, который служит загоном для коровы и курицы. Также у последней здесь есть гнездо, сделанное из соломы, в котором лежит яйцо. Для коровы же сделано специальное корыто с водой." +
                "\n\nПерсонажи:\nХод, Гердур, Фроднар, Ралоф."+
                "\n\nКвесты:\n«Перед бурей» — одна из ключевых локаций квеста.\nРубка дров — одно из двух мест, где может находиться квестодатель.";
        }
        // RiverwoodTrader
        public List<MousePoint> GetRiverwoodTrader()
        {
            return RiverwoodTrader;
        }
        public string GetRiverwoodTraderDescription()
        {
            return "Название:\nРивервудский торговец.\n\n" +
                "Описание:\nМагазин находится в центре Ривервуда и является одним из трёх градообразующих строений, наряду с лесопилкой Хода и Гердур и таверной «Спящий Великан». Это здание является двухэтажным и довольно высоким в целом." +
                "\n\nПерсонажи:\nЛукан Валерий, Камилла Валерия." +
                "\n\nКвесты:\n«Золотой коготь» — место начала квеста.\n«Письмо Камилле Валерии» — возможное местонахождение целевого персонажа.";
        }
        // SleepingGiantInn
        public List<MousePoint> GetSleepingGiantInn()
        {
            return SleepingGiantInn;
        }
        public string GetSleepingGiantInnDescription()
        {
            return "Название:\nТаверна «Спящий великан».\n\n" +
                "Описание:\nТаверна «Спящий великан» — одна из многих таверн Скайрима, находится в поселении Ривервуд. Таверна представляет собой просторное одноэтажное здание, построенное из дерева на каменном фундаменте в стиле, характерном для жителей Скайрима. Наряду с магазином «Ривервудский торговец» и лесопилкой Хода и Гердур, заведение представляет важный для поселения объект, являясь центром досуга и местом, в котором останавливаются путешественники — основной источник денег и новостей для местных жителей." +
                "\n\nПерсонажи:\nДельфина, Оргнар, Эмбри." +
                "\n\nКвесты:\n«Рог Юргена» — часть квеста проходит в данной локации.\n«Клинок во тьме» — часть квеста проходит в данной локации.\n«Крыса, загнанная в угол» — часть квеста проходит в данной локации.\n«Стена Алдуина» — часть квеста проходит в данной локации.";
        }
        // SvensHouse
        public List<MousePoint> GetSvensHouse()
        {
            return SvensHouse;
        }
        public string GetSvensHouseDescription()
        {
            return "Название:\nДом Свена и Хильде.\n\n" +
                "Описание:\nЭто небольшой деревянный дом, построенный в нордском стиле. Располагается около южного входа в поселение Ривервуд. Также он имеет небольшую террасу, на которой расположены: пара бочек, поленница дров, а также стул и дубильный станок, на котором в течение дня с небольшими перерывами работает Хильде." +
                "\n\nПерсонажи:\nСвен, Хильде." +
                "\n\nКвесты:\n«Любовное письмо» — возможное местонахождение одного из квестодателей.";
        }
    }
}
