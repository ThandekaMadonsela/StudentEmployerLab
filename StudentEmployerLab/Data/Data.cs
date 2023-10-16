using StudentEmployerLab.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEmployerLab.Data
{
    public static class Data

    {

        public static List<string> FirstNames = new List<string>
            {
                "John", "Alice", "Bob", "Eva", "Michael", "Sophia", "David", "Olivia",
                "Daniel", "Emma", "James", "Emily", "William", "Ava", "Joseph", "Mia",
                "Christopher", "Abigail", "Matthew", "Charlotte"
            };

        public static List<string> Surnames = new List<string>
            {
                "Smith", "Johnson", "Brown", "Lee", "Davis", "Williams", "Jones", "Miller",
                "Taylor", "Wilson", "Anderson", "Moore", "Jackson", "White", "Harris",
                "Martin", "Thompson", "Walker", "Clark", "Lewis"
            };

        public static List<string> telephoneNumbers = new List<string>
            {
                "0123456789", "0112345678", "0134567890", "0145678901", "0156789012",
                "0167890123", "0178901234", "0189012345", "0190123456", "0201234567",
                "0212345678", "0223456789", "0234567890", "0245678901", "0256789012",
                "0267890123", "0278901234", "0289012345", "0290123456", "0301234567"
            };

        public static List<string> SAIDs = new List<string>
            {
                "5905116388065", "7302265708368", "9004172179992", "6804273533323",
                "5107217249236", "5902272315207", "8505153463408", "9107226107399",
                "5708155319433", "7006202415153", "9403182353832", "9108151749826",
                "6603202562140", "8302271714988", "9206124551888", "6806111665734",
                "6101163646023", "9408231394990", "9802123139483", "5707123345887"
            };

        public static List<string> StreetNames = new List<string>
            {
                "Main Street", "Oak Avenue", "Maple Road", "Elm Crescent", "Cedar Lane",
                "Willow Street", "Pine Avenue", "Birch Road", "Magnolia Close", "Acacia Way",
                "Rosemary Lane", "Jasmine Street", "Lily Road", "Sunflower Avenue", "Bluebell Crescent",
                "Iris Lane", "Lavender Road", "Marigold Way", "Violet Street", "Daisy Lane"
            };

        public static List<string> Cities = new List<string>
            {
                "Johannesburg", "Cape Town", "Durban", "Pretoria", "Port Elizabeth",
                "Bloemfontein", "Pietermaritzburg", "East London", "Nelspruit", "Kimberley",
                "Polokwane", "Rustenburg", "George", "Mthatha", "Vereeniging", "Witbank",
                "Upington", "Mafikeng", "Bethlehem", "Klerksdorp"
            };

        public static List<string> Provinces = new List<string>
            {
                "Gauteng", "Western Cape", "KwaZulu-Natal", "Eastern Cape", "Limpopo",
                "Mpumalanga", "North West", "Free State", "Gauteng", "KwaZulu-Natal",
                "Northern Cape", "Eastern Cape", "Western Cape", "Gauteng", "Limpopo",
                "North West", "Mpumalanga", "Free State", "KwaZulu-Natal"
            };

        public static List<string> AddressNames = new List<string>
            {
                "First home","Second home", "University residence","Holiday residence"
            };

        public static List<string> StudentNumbers = Util.GenerateRandomNumbers(20, 10000000, 99999999, 8);
        public static List<string> StuffNumbers = Util.GenerateRandomNumbers(20, 1000000, 9999999, 7);


        public static List<string> CompanyNames = new List<string>
        {

        "Osinski, Cormier and Homenick","Larkin, Hamill and Schaefer","Heaney, Feil and Johnston",
        "Considine, Schuppe and Cronin","Emard, Wilkinson and Runolfsdottir","Rau, Smitham and Klein",
        "Davis, Dickinson and Bruen","Abshire, Bergnaum and Anderson","Fadel, Stroman and Nitzsche",
        "Hane, Konopelski and Hills","Satterfield, Conroy and Stracke","Harber, Kunze and Little",
        "Kilback, Hauck and Parker", "Bogisich, Mohr and Turner","Corkery, Willms and Will", "Barton, Blick and Strosin",
        "Hauck, Torp and Dickinson","Jakubowski, Reynolds and Walter","Fisher, Bradtke and Stracke",
        "Flatley, Armstrong and Johns","Harvey, Koelpin and Schamberger", "Funk, Zulauf and Weissnat",
        "Gutmann, Kessler and Thiel", "Jenkins, Moen and Heller", "Spinka, Dare and West","Kerluke, Christiansen and Morar",
            "Price, Haley and Brown",

        "Goyette, Cole and Pagac",

        "Klein, Dach and Wiza",

        "Thompson, Torp and Davis",

        "McDermott, Turner and Brakus",

        "Sporer, Gerlach and Gusikowski",

        "Russel, Windler and Abbott",

        "Flatley, Olson and Swaniawski",

        "Herman, Will and Connelly",

        "Sporer, Koch and O'Hara",

        "Bradtke, Goodwin and Homenick",

        "Kuphal, Strosin and Goyette",

        "Shanahan, Collier and Keeling",

        "Hauck, Krajcik and Legros",

        "Kihn, Roberts and Gleichner",

        "Stehr, Runte and Braun",

        "Abernathy, Wyman and Herzog",

        "Nader, Fahey and Marquardt",

        "Boehm, Flatley and Streich",

        "Hickle, Lesch and Littel",

        "Connelly, Beier and Schuster",

        "Kemmer, McCullough and Wilkinson",

        "Stanton, O'Connell and Kreiger",

        "Fadel, Botsford and Bogisich"

    };



        public static List<string> JobDescription = new List<String>

  {

    "talk about contentment!!!: Tempora et facilis fugiat laboriosam possimus ex. Quis vero quo sit numquam. Facere facilis eos. Consequuntur ut id quos voluptatibus. Natus quidem qui fugit nobis quas ratione quaerat unde. Sit omnis omnis ab sunt. Dolorem voluptas voluptas ea sed.",

    "I tried to nail it but got strawberry all over it.: Ea quidem qui sed et quis ullam. Doloribus in sunt quasi facere aut excepturi. Corporis qui tenetur. Nihil voluptate aliquam at. Voluptates dignissimos excepturi ipsam excepturi. Aliquam consequuntur molestiae aut quis eius dolorem quam at voluptatem. Iure eveniet sit doloremque at.",

    "My neighbor Lori has one of these. She works as a taxidermist and she says it looks whopping.: Officiis sed optio odio et expedita. Dolorem quisquam provident voluptatibus. Et omnis dolorem vel voluptatibus. Veritatis et ea eum inventore nostrum. Ratione architecto accusantium ut. Quo animi voluptas et. Consectetur iusto iste ducimus. Labore commodi laboriosam libero vitae iste odio.",

    "one of my hobbies is guitar. and when i'm playing guitar this works great.: Ea qui modi sapiente nulla et maiores laboriosam ut. Qui temporibus voluptatibus hic quas fugiat non molestiae. Occaecati libero animi quas. Est asperiores et. Quis accusantium asperiores aut harum est. Ut laboriosam ullam.",

    "heard about this on new jersey hip hop radio, decided to give it a try.: Eligendi ducimus ut error quod. Quaerat tempore recusandae tempore qui rerum sequi itaque adipisci rerum. Quo dolore consequatur. Animi odio voluptas a ut non voluptates rerum similique voluptate. Culpa quisquam adipisci impedit dolorem qui delectus.",

    "My co-worker Cato has one of these. He says it looks sopping.: Quibusdam neque similique sed dolorum ut cum laborum. Velit ut qui et deserunt sit. Quasi culpa dolorem aut eius mollitia. Rem numquam explicabo. Quaerat sunt ea et quis omnis amet eligendi velit. Blanditiis quo odit molestiae labore ab. Modi ut sequi eum aut. Error dolore tempora voluptate magni.",

    "heard about this on brazilian radio, decided to give it a try.: Facere at minima delectus minus. Nemo assumenda aliquid perferendis earum. Quo quasi accusantium. Dolor hic vitae neque in qui. Quis iste ullam vero possimus assumenda nihil non. Officia omnis aperiam similique vero et et autem rerum. Nemo assumenda repellat accusantium tempora temporibus beatae illum blanditiis.",

    "I tried to pepper it but got prune all over it.: Non expedita sunt quia enim aut sed officia qui distinctio. Et et odio vero inventore. Enim non qui ducimus dicta blanditiis suscipit iste aut eveniet. Hic accusamus illo qui a illum modi nemo quae. Impedit sed quaerat inventore qui. Et neque in sint velit et.",

    "It only works when I'm Niger.: Nihil ducimus dolores. In quos sit earum nesciunt molestiae natus impedit quisquam. Rem quo sequi occaecati quos omnis illum. Nesciunt sed est et esse maiores veniam et voluptas harum. Consequatur voluptatem aut.",

    "It only works when I'm New Caledonia.: Sed exercitationem vel. Ipsum vitae delectus et quia. Rerum consequatur rerum qui minus quis debitis. Qui quisquam voluptates et et dolorem dignissimos doloremque sit. Et doloribus quasi non. Enim in doloribus atque nesciunt aut sit sit amet reiciendis. Consequatur repellendus tempore amet aut rerum et totam enim. Atque nihil impedit rerum possimus qui necessitatibus blanditiis.",

    "this product is complimentary.: Et aliquam sed nesciunt. Qui quia qui. Explicabo similique possimus non eum et vitae quia consequatur. Ea deserunt voluptas et ea consectetur. Officia ut quia et.",

    "It only works when I'm Juan de Nova Island.: Itaque ex perspiciatis sed est qui. Hic velit sint occaecati. Earum assumenda esse nesciunt possimus in quo laborum. Sed necessitatibus consequatur est ut officia temporibus blanditiis accusantium. Porro dolores blanditiis ad voluptatem et hic. Culpa est dolor non impedit culpa ut.",

    "I saw one of these in Saint Lucia and I bought one.: Impedit vero incidunt et sit beatae tempora recusandae eos. Nostrum aut iure sint enim vero reiciendis voluptas. Sed beatae cum id qui repudiandae non. Neque mollitia ea culpa ea nihil et voluptate amet. Et autem alias ducimus autem qui natus quam tempore laborum. Dolor error est aperiam. Facilis quia assumenda odit quo.",

    "It only works when I'm Cook Islands.: Praesentium eos consequatur fugiat officiis possimus molestiae eveniet. Nemo suscipit illo saepe provident recusandae provident numquam alias voluptatem. Pariatur doloribus fugit blanditiis. Ratione qui doloribus maiores qui accusantium aperiam quis totam in. Impedit quia debitis perspiciatis. Est et non dignissimos quaerat dicta. Accusamus ipsam facere. Culpa numquam quia.",

    "I saw one of these in Saint Pierre and Miquelon and I bought one.: Nemo quo incidunt ullam a quia et nemo sint. Sit incidunt architecto molestiae culpa. Voluptatibus rerum soluta. Assumenda velit qui accusamus. Praesentium dolorum corporis provident autem et eligendi et.",

    "this product is gracious.: Dolor delectus nisi et aut quos nobis. Enim sint assumenda quia sunt qui enim sed officia. Saepe inventore quae consectetur corporis. Commodi earum placeat. Sed odio et.",

    "It only works when I'm Bolivia.: Eum inventore ipsum omnis aliquid eum voluptatum explicabo adipisci. Occaecati consectetur blanditiis rerum et. Nihil molestiae velit reiciendis. Voluptatum est veniam deleniti qui itaque dolor sit magni. Autem est velit. Sint consequatur repellat est architecto qui sed numquam. Aut voluptate dolorem et ducimus quaerat earum eaque voluptatibus eum.",

    "i use it on Mondays when i'm in my fort.: Totam aut et aut rerum. Ex saepe sunt alias. Atque eos nemo ut et voluptas possimus consequuntur quo. Commodi autem nemo voluptas. Rerum harum quo natus veniam. Et enim nobis. Molestias fugiat labore sapiente consectetur et dicta.",

    "My co-worker Rey has one of these. He says it looks uneven.: Temporibus alias enim eum quod quia reprehenderit expedita est dolorum. At voluptatibus itaque. Corrupti pariatur illo amet accusamus atque. Ut eos cupiditate velit dolorem repellat quo vitae aut. Non molestiae expedita sed. Dolorum possimus rem sapiente. Nihil qui et omnis laudantium accusantium repellat. Qui aut dolore et eligendi laborum in repudiandae fuga rerum.",

    "I tried to annihilate it but got bonbon all over it.: Officiis in autem. Voluptatem aut reprehenderit. Perferendis qui autem nostrum ipsam eius velit animi et et. In debitis consequuntur quod. Aperiam debitis sint. Qui saepe qui qui.",

    "talk about fury.: Quis non cum accusantium quia dolores. Qui qui pariatur quidem asperiores sunt voluptate eveniet delectus ut. Nisi aut excepturi et et aut molestias debitis. Corrupti a minima. Enim sit est. Veniam quo et veritatis quo.",

    "this product is slurpee.: Molestiae qui dolorem. Unde minima iste fugit delectus dolorem nulla ipsum. Cumque et consectetur est consequatur sapiente corporis ex possimus. Culpa maxime laborum amet maiores debitis vel. Nesciunt recusandae laudantium qui sit. Deleniti omnis vel qui dolores in inventore. At modi hic eaque eos labore nemo.",

    "The box this comes in is 3 kilometer by 5 inch and weights 13 ton.: Nobis voluptatem qui provident autem est illum velit. Quo non possimus rerum nostrum quia exercitationem. Accusamus eligendi eveniet et doloribus sunt rem alias. Voluptatem iste delectus. Quia ipsum dicta quos ea.",

    "heard about this on balearic beat radio, decided to give it a try.: Voluptas debitis officia enim commodi et cum eligendi quia. Perspiciatis et odio. Aut officia omnis et tenetur aut corporis blanditiis voluptatibus. Voluptates sunt quia explicabo. Aut possimus quis maiores. Consequatur exercitationem impedit qui rem rerum praesentium. Porro ullam ut repellendus et.",

    "My bass loves to play with it.: Ut modi eos est facilis dolorem commodi est. Dolor atque omnis molestiae natus quo. Vel doloribus harum et laboriosam quis eos sequi. Eos eum et optio voluptas laboriosam. Aperiam et pariatur assumenda eos sint rerum aut et necessitatibus. Sed autem omnis. Earum possimus rerum. Odio aperiam tempora hic molestiae et corporis animi dolores et.",

    "My neighbor Betha has one of these. She works as a teacher and she says it looks wide.: Enim repudiandae nesciunt ad hic exercitationem commodi ipsam eos. Molestias dolor occaecati est maiores neque. Commodi sed ratione. Sit eligendi neque ducimus culpa. Et adipisci et excepturi officia. Suscipit impedit vero et nulla ex. Cumque odio consequuntur neque similique autem qui.",

    "I tried to decapitate it but got coconut all over it.: Quas reiciendis a fugiat error. Distinctio ab iste harum corporis illo alias consectetur reiciendis odio. Cumque ea in minus et autem et autem. Vitae dignissimos tempora sit dicta. Molestiae quis quia unde aliquid qui ea. Dolorum et similique et iure voluptatibus. Facilis omnis occaecati corrupti dolor qui. Repellendus maiores dignissimos aut sed numquam et nobis.",

    "It only works when I'm Malaysia.: Quisquam quo nulla ut rerum. Asperiores eos non quis. Quis veniam in vitae laboriosam quia vel. Recusandae enim ipsam. Dolor consectetur ea voluptates quibusdam dolore. Ad nostrum voluptatem eius omnis esse assumenda autem asperiores. Quod dolores accusantium sed autem laboriosam. Odio eius aut quaerat atque.",

    "My penguin loves to play with it.: Dolores nemo inventore corrupti quisquam illum eum. Quis a non facere consequatur. Sint ratione voluptatem quisquam. Quis totam fuga voluptas reprehenderit omnis rerum consequatur. Quo sit nisi doloribus quia. Facilis eum accusantium quas.",

    "this product is hyper.: Est sed cupiditate nulla explicabo sunt. Dolores esse corrupti corrupti iusto nesciunt. Hic fuga facere. Veniam fuga rerum soluta. Autem odio expedita. Corporis quod perferendis voluptates dolor quia minima et et tempore. Consequatur reiciendis at sunt perferendis sit non consequuntur voluptatem ducimus. Esse aut tenetur aperiam quia.",

    "I tried to nab it but got salad all over it.: Non nostrum aut sed dolorem aut dignissimos. Ut nobis occaecati. Et itaque non optio. Recusandae quo fugit. Doloribus id distinctio. Officiis totam reiciendis consequatur. Exercitationem facere molestiae rerum.",

    "I saw one of these in Moldova and I bought one.: Eos et aut optio officia in est temporibus eius repudiandae. Ab aperiam ratione ipsam iusto perspiciatis dicta quod. Accusamus tempora ipsa iure eius. Impedit laudantium qui ab assumenda veniam consequatur est doloribus sed. Delectus omnis animi et est. Inventore ad enim deserunt laboriosam perspiciatis qui nemo et. Accusantium fugiat tempora nihil eveniet qui ut.",

    "I tried to slay it but got truffle all over it.: Ut sit nihil voluptates adipisci nostrum aut et rerum. Et culpa quo. Sit reiciendis similique accusamus porro. Libero laborum in architecto neque illo. Ut magni sunt unde aut voluptatem et est earum illum. Rerum harum voluptas nesciunt.",

    "this product is revolting.: Et sint voluptatem voluptates id et laudantium excepturi labore. Et exercitationem ut laudantium nemo maiores. Voluptatum qui ullam voluptatibus aut aut aspernatur blanditiis laboriosam. Ipsa culpa qui ratione nemo beatae quia. Architecto officiis id quis commodi.",

    "The box this comes in is 4 light-year by 5 inch and weights 11 megaton!!: Non qui reprehenderit aut mollitia accusantium adipisci. Qui debitis sapiente ut assumenda dolore suscipit inventore saepe nemo. Natus amet et. Inventore sit exercitationem non non odio dolorem aut non. Tempora eligendi perferendis ea libero minima. Consequatur aliquam error omnis. Voluptas aperiam eaque esse eveniet repellat et non cumque. Est id quasi laborum at ab quis.",

    "talk about hatred!!!: Eligendi quasi et autem dolorum ratione sed nihil. Ea minima earum dolorem quod eius omnis molestias. Sint enim sed pariatur. Blanditiis qui deserunt eos temporibus reiciendis quam. Aut sed dolor explicabo.",

    "i use it this time when i'm in my port-a-potty.: Distinctio qui nemo beatae nemo. Omnis consequatur nam voluptatem aspernatur. Aut quod rerum. Quia quos minima. Adipisci cupiditate sunt fuga earum. Aut necessitatibus id.",

    "I tried to belly-flop it but got Turkish Delight all over it.: Non sunt esse a voluptates nobis autem. Deleniti provident tenetur dolorum neque placeat incidunt est deleniti soluta. Perspiciatis labore et architecto et consectetur tempore dolores consequatur. Amet est aut tempora sed omnis et rerum dolor. Sit autem sed atque qui.",

    "one of my hobbies is web-browsing. and when i'm browsing the web this works great.: Sit ipsam blanditiis. In facere et et. Perspiciatis et numquam cupiditate. Omnis autem ex nihil. Eos error temporibus exercitationem. Iste amet quis laudantium et voluptas corporis sit quos.",

    "i use it this time when i'm in my port-a-potty.: Aut repellat totam. Ut iusto deserunt rerum id consequatur. Dolorem harum aperiam consequatur. Sit et veniam et beatae. Repellat eos laboriosam explicabo exercitationem possimus ut a natus.",

    "My neighbor Albertina has one of these. She works as a gardener and she says it looks humongous.: Et et doloribus repellat non. Consequatur odit in sunt ut cupiditate praesentium error. Aut reiciendis dolorem labore numquam et ut nihil qui. Atque tempore ea officia atque. Et mollitia quam vel. Mollitia sit saepe molestiae quis optio sapiente culpa id.",

    "My neighbor Karly has one of these. She works as a gambler and she says it looks tall.: Rerum voluptas delectus quasi magni quia quisquam voluptate sequi eos. Sit delectus minima sed dolores omnis eius magni numquam quos. Et eum totam. Quia officia praesentium et. Sed possimus velit voluptatem officiis.",

    "My locust loves to play with it.: Magni laboriosam alias vitae quia dolorem sunt ut. Consequatur dolorem cumque vel amet minus inventore architecto. Animi temporibus sunt dolor eius nam totam vitae distinctio ducimus. Dolor est id voluptatem fugiat. Expedita aut porro. Nam delectus explicabo. Repudiandae eum cum totam rem voluptatem voluptate id mollitia minus.",

    "talk about fury.: Et numquam molestiae voluptas voluptas veritatis dicta. Enim rem et placeat aliquam ratione aut incidunt quia et. In aut molestias inventore voluptas nesciunt est veritatis. Minus dolor eius et fuga fuga omnis quos exercitationem ut. Sint non autem hic quae vel. Cum maxime velit velit omnis. Quod voluptas qui eum voluptatibus est a.",

    "This product works so well. It imperfectly improves my baseball by a lot.: Id molestias nemo maiores voluptatum eum laborum minus et. Asperiores et iste et et asperiores necessitatibus. Excepturi sit suscipit sequi non id sit. Dignissimos at qui excepturi non repudiandae ipsum officiis tempora ipsam. Velit adipisci eaque iste facere.",

    "talk about bliss!!: Quasi temporibus dolores perspiciatis voluptatem quis. Optio tempora tempora accusantium soluta asperiores tenetur. Et doloremque recusandae voluptate esse pariatur. Id et veniam quasi et similique molestiae sapiente culpa. Exercitationem reprehenderit quia aliquid dolorem quibusdam eius. Sint adipisci veniam dolorem magnam dignissimos alias. Dicta atque quas rerum et. Aliquid molestias est.",

    "This product works quite well. It pointedly improves my golf by a lot.: Beatae et maiores quae velit aut eius voluptas. Ut voluptas rerum corporis illo. Dolorem ab inventore distinctio sed. Quia culpa quae ut. Illum consequuntur recusandae quisquam nemo voluptatem id. Reprehenderit in nostrum qui alias ipsam in qui similique. Eaque eius unde libero harum saepe est molestiae dolor.",

    "heard about this on alternative dance radio, decided to give it a try.: Quae est debitis odit itaque quaerat beatae dolor. Numquam sequi magnam magni aliquam molestias. Corrupti reiciendis reiciendis et at. Voluptatem a et ut earum numquam et doloremque maxime animi. Temporibus assumenda delectus nostrum enim. Ipsum voluptas aut ut id asperiores. Veniam optio voluptatem in. Nemo dolore est molestias eos omnis omnis vel.",

    "The box this comes in is 5 kilometer by 6 yard and weights 18 gram.: Placeat odio reprehenderit id qui et esse. Accusantium iure totam ut qui voluptas quas enim. Eum nihil quo voluptas nihil dicta laborum est odio. Hic et quasi. Ullam qui perferendis. Quisquam repellat numquam. Nobis qui voluptatibus animi omnis est tempore earum est quod. In minus possimus aut eos ab autem.",

    "one of my hobbies is sailing. and when i'm sailing this works great.: Sequi odio culpa perferendis architecto minus et dicta. Harum et rem deserunt omnis ratione earum. Veniam nam enim exercitationem quidem veritatis quod non non earum. Est qui quam provident repellat. Aut quam vitae voluptatem temporibus. Corrupti explicabo vel quidem sunt magni. Adipisci sit alias iusto esse dolore ducimus totam est et. Illum dolorem ut aut."

};



        public static List<string> Department = new List<string>

    {

        "Automotive, Electronics & Home",

        "Movies & Beauty",

        "Books, Toys & Games",

        "Kids & Baby",

        "Home",

        "Sports & Tools",

        "Health, Computers & Tools",

        "Grocery, Games & Sports",

        "Jewelery, Outdoors & Games",

        "Grocery",

        "Clothing",

        "Garden",

        "Shoes",

        "Industrial, Garden & Clothing",

        "Tools, Beauty & Clothing",

        "Garden, Computers & Toys",

        "Shoes, Electronics & Music",

        "Health",

        "Toys & Toys",

        "Clothing & Tools",

        "Movies & Garden",

        "Industrial",

        "Games & Health",

        "Kids",

        "Music",

        "Home & Electronics",

        "Garden, Sports & Garden",

        "Shoes & Automotive",

        "Movies & Computers",

        "Jewelery & Music",

        "Beauty & Toys",

        "Sports & Toys",

        "Toys",

        "Kids",

        "Outdoors",

        "Movies",

        "Games & Beauty",

        "Garden, Jewelery & Books",

        "Kids & Shoes",

        "Beauty, Clothing & Garden",

        "Garden",

        "Kids",

        "Music & Movies",

        "Games & Beauty",

        "Jewelery & Shoes",

        "Kids",

        "Books",

        "Jewelery",

        "Books, Outdoors & Grocery",

        "Outdoors"

    };



        public static List<DateOnly> StartDates = new List<DateOnly>

    {

        new DateOnly(2024,06,22),

        new DateOnly(2024,10,10),

        new DateOnly(2024,02,13),

        new DateOnly(2025,11,08),

        new DateOnly(2024,11,05),

        new DateOnly(2025,08,18),

        new DateOnly(2025,08,03),

        new DateOnly(2024,02,27),

        new DateOnly(2024,03,10),

        new DateOnly(2024,07,19),

        new DateOnly(2024,01,10),

        new DateOnly(2024,11,05),

        new DateOnly(2024,02,01),

        new DateOnly(2024,05,24),

        new DateOnly(2024,10,19),

        new DateOnly(2024,02,21),

        new DateOnly(2025,01,08),

        new DateOnly(2024,10,17),

        new DateOnly(2025,11,27),

        new DateOnly(2024,10,12),

        new DateOnly(2025,12,16),

        new DateOnly(2024,03,20),

        new DateOnly(2024,01,26),

        new DateOnly(2025,04,21),

        new DateOnly(2025,09,27),

        new DateOnly(2024,06,21),

        new DateOnly(2024,02,29),

        new DateOnly(2024,03,05),

        new DateOnly(2024,05,06),

        new DateOnly(2025,05,20),

        new DateOnly(2024,01,27),

        new DateOnly(2025,06,18),

        new DateOnly(2024,12,16),

        new DateOnly(2025,03,03),

        new DateOnly(2025,10,28),

        new DateOnly(2025,09,04),

        new DateOnly(2025,03,08),

        new DateOnly(2025,05,04),

        new DateOnly(2024,07,12),

        new DateOnly(2024,11,03),

        new DateOnly(2024,06,18),

        new DateOnly(2025,02,11),

        new DateOnly(2024,08,01),

        new DateOnly(2025,10,23),

        new DateOnly(2024,06,13),

        new DateOnly(2024,10,20),

        new DateOnly(2024,11,18),

        new DateOnly(2024,08,04),

        new DateOnly(2024,06,26),

        new DateOnly(2024,03,07)

    };



        public static List<string> PartyNames = new List<string>

    {

           "Stage And Screen firewall",

           "Reggae panel",

           "Non Music alarm",

           "Latin interface",

           "Latin port",

           "Metal interface",

           "Jazz monitor",

           "Electronic transmitter",

           "Electronic program",

           "Classical hard drive",

           "Stage And Screen card",

           "Jazz pixel",

           "Folk alarm",

           "Stage And Screen program",

           "Funk sensor",

           "World bus",

           "Metal hard drive",

           "Classical port",

           "Soul application",

           "Rock card",

           "Funk circuit",

           "Non Music interface",

           "Country matrix",

           "Metal panel",

           "Jazz card",

           "Folk pixel",

           "Latin interface",

           "World feed",

           "Non Music sensor",

           "Blues capacitor",

           "Hip Hop system",

           "Classical hard drive",

           "Rap array",

           "Rock array",

           "Blues sensor",

           "Funk panel",

           "Latin pixel",

           "Latin matrix",

           "Blues feed",

           "Reggae alarm",

           "World circuit",

           "Metal driver",

           "Folk interface",

           "Country protocol",

           "Reggae array",

           "Country program",

           "Soul circuit",

           "Stage And Screen capacitor",

           "Blues interface",

           "Pop matrix"

    };



        public static List<string> Rates = new List<string>

        { "R59.98","R212.24", "R162.54", "R163.03","R256.09", "R113.18", "R174.73", "R66.76",
          "R155.29", "R72.44", "R117.33","R11.95", "R186.26", "R238.20", "R168.10","R189.64",
          "R255.67","R16.83","R43.62","R22.07",





     "R155.30",

     "R43.00",

     "R82.99",

     "R144.06",

     "R216.12",

     "R186.86",

     "R258.18",

     "R199.52",

     "R280.08",

     "R140.67",

     "R243.00",

     "R49.50",

     "R94.09",

     "R112.00",

     "R263.25",

     "R258.84",

     "R204.44",

     "R191.14",

     "R199.53",

     "R23.39",

     "R14.30",

     "R247.84",

     "R213.01",

     "R215.23",

     "R85.41",

     "R196.12",

     "R252.83",

     "R200.19"

 };


    }
}
