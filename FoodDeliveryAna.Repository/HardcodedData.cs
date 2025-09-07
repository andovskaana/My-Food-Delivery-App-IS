using System;
using System.Collections.Generic;
using FoodDeliveryAna.Domain.DomainModels;

namespace FoodDeliveryAna.Repository
{
    public static class HardcodedData
    {
        public static List<Restaurant> GetRestaurants()
        {
            var restaurantList = new List<Restaurant>();

            // === Amigos Centar
            {
                var restaurant = new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Amigos Centar",
                    Description = "Доставуваме до Вашата врата",
                    StreetAddress = "",              // Java 3rd param
                    City = "Skopje",
                    ImageUrl = "https://korpa.ba/restaurant_uploads/dpkyYY48d8Kn70RlCBxJkc0HoK6mGjS6.jpg",
                    Category = "Mexican",
                    DeliveryPrice = 25
                };

                // Section: Стартери 🧀
                var starters = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Стартери 🧀",
                    RestaurantId = restaurant.Id
                };
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Nachos",
                    Description = "Мексикански чипс прелиен со топен кашкавал и пикантен начос кашкавал, сервиран со салса и крем сос",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/BsQOsbCBZe6eKxKzvvXBz0b0aGd0uTJT.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Guacamole",
                    Description = "Свежа кремаста салата од авокадо зачинета со свежи домати, кромид, лимета и коријандер, сервирана со Мексикански чипс",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/3LCIpZNOyaBCDyw4bowAZ0Te9cQTgAvX.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Roll de pollo",
                    Description = "Пилешко филе во крцкава тортиља сервирано со крем сос",
                    Price = 390.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/73I4j0qh7SHlfjweX4xGphalYCW80LE1.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Onion Rings",
                    Description = "Вкусен похован кромид сервиран со сос од мед и сенф, салса и крем сос",
                    Price = 390.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/rwXmagsLeUCnD8F1tLHMqJkxLApI8ZyR.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Corn Fritters",
                    Description = "Вкусни зачинети ќофтиња од пченка, сервирани со пико де гајо, авокадо, крем сос и салса",
                    Price = 370.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/c71vEsHD07gZaSXvveMEDCCxpOO0Bgs8.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Cheesy Croquettes",
                    Description = "Вкусни крокети од компир и семки од афион сервирани со кремаст сос од растопена горгонзола",
                    Price = 410.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/WolgJek0aZOKdyh4XJ9LY6Wcjt8z6x2F.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Shared Platter",
                    Description = "Селекција на пршута, пармезан, намаз од горгонзола, маслинки, шери домати и крекери",
                    Price = 870.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/4SG3wQT7l84wHMZGjMv0u3vhYHULbAuN.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Salmon Roll",
                    Description = "Тортиља, крем сос, лосос, авокадо, спанаќ, киноа, дресинг",
                    Price = 620.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/2wBpsH6RPvSqY9SCxjEmChrji1lW29WY.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Grande Totopos",
                    Description = "Традиционален Мексикански чипс сервиран со салса, крем сос, начос кашкавал и пико де гајо",
                    Price = 490.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/Mkg8xxLVgsldVGHSfclznkE9ACjAydlU.jpg",
                    MenuId = starters.Id
                });
                starters.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Shrimp Tempura",
                    Description = "Панирани шкампи, сервирани со кремаст аиоли сос",
                    Price = 590.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/OH6XqLGBpIi9Q1fWDdMovpv0jKEKYqN9.jpg",
                    MenuId = starters.Id
                });
                restaurant.Menus.Add(starters);

                // Section: Салати 🥗
                var salads = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Салати 🥗",
                    RestaurantId = restaurant.Id
                };
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Cheff Salad",
                    Description = "Салата со марула, ајсберг, авокадо, печурки, пиперки, морков, прелиена со свеж дресинг од лимета и крцкава сланина",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/xz1R9iaxvtWWgc7gY0rPaHOjoBFmYdk3.jpg",
                    MenuId = salads.Id
                });
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Amigos Salad",
                    Description = "Салата од марула, сецкано пилешко филе и печурки, гарнирана со пармезан, маслинки, мексикански микс и вкусен дресинг",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/iqtDBNxMOFCj28Uyt6l3fweA7rgxXF8E.jpg",
                    MenuId = salads.Id
                });
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Quinoa Salad",
                    Description = "Салата со киноа, авокадо, наут, марула, црвен кромид, грашак, грав и пченка, зачинета со дресинг од маслиново масло, сенф и лимон",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/zBy8hR8RKzcPrQt4FDgvhQxIffh4PxeO.jpg",
                    MenuId = salads.Id
                });
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Beef Salad",
                    Description = "Сотиран бифтек сервиран врз рукола, шери домат и пармезан прелиено со балсамико дресинг",
                    Price = 850.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/9k4npQ7VVJHl2Mq5xAbif680tfl2dx3N.jpg",
                    MenuId = salads.Id
                });
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Roncalina Salad",
                    Description = "Салата со печени тиквички, модар домат и пиперки, збогатенa со кашкавал, сервирани врз марула и вкусен дресинг",
                    Price = 440.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/W8KaMz4isIhK9RVx8zZYbIidt14UsPPo.jpg",
                    MenuId = salads.Id
                });
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Caesar Salad",
                    Description = "Традиционална Цезар салата со марула, ајсберг, пилешко филе, тостиран леб и пармезан, прелиена со дресинг",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/5Ps3vCqE93CeP4DuScFSGH0UiBCGJXt0.jpg",
                    MenuId = salads.Id
                });
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Cobb Salad",
                    Description = "Здрава протеинска салата со авокадо, пилешко филе, варено јајце, домати и крцкава сланина, сервирани врз марула и рукола со дресинг од мед и сенф",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/MnL7X05ukdx0xFJcbgvbOiN7VXT6x73F.jpg",
                    MenuId = salads.Id
                });
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Goat Cheese Salad",
                    Description = "Вкусна салата со свеж спанаќ, авокадо, поховано козјо сирење, лешници, домати, маслинки, балзамико дресинг",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/7qKonfVw22HMTU32ItQEtbtfiPVhSfQq.jpg",
                    MenuId = salads.Id
                });
                salads.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Rucola Salad",
                    Description = "Свежа салата со рукола, шери домати и пармезан, прелиена со балсамик сос",
                    Price = 410.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/V6OtGnWp7c2vpvBCgk9By39xvlJekIRR.jpg",
                    MenuId = salads.Id
                });
                restaurant.Menus.Add(salads);

                // Section: Tortillas 🌮
                var tortillas = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Tortillas 🌮",
                    RestaurantId = restaurant.Id
                };
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Quesadilla",
                    Description = "Традиционален Мексикански оброк од две тортиљи полнети со растопен кашкавал и ваш избор од пилешко филе, печурки или печени зеленчуци, сервиран со салса и крем сос",
                    Price = 470.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/3DWqFGbUcqzb5pPk0P3s6y5BS8basim8.jpg",
                    MenuId = tortillas.Id
                });
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Burrito",
                    Description = "Голема тортиља полнета со ориз, топен кашкавал, крем сос и ваш избор од пилешко филе, телешки рамстек или мешани зеленчуци, сервирано со салса",
                    Price = 490.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/CNBRIRjs9OS6eHNnHUC5vS1BxEHWXnPB.jpg",
                    MenuId = tortillas.Id
                });
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Fajitas",
                    Description = "Ваш избор од пилешко, телешко, или свинско месо, припремено со микс од зеленчуци и растопен кашкавал, послужено со свежа салата, шест тортиљи, ориз, пико де гајо, салса и крем сос (Совршено за двајца)",
                    Price = 950.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/z1Uiy5qqJqm4wiueuHfduvyG0nkeY12a.jpg",
                    MenuId = tortillas.Id
                });
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Taco",
                    Description = "Препознатливо Mексиканско јадење од две превиткани тортиљи полнети со зеленчуци, кашкавал, начос сирење и избор од пилешко, телешко или свинско месо. Сервирано со ориз, салса и крем сoс",
                    Price = 510.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/r0WyfLiV30wX8pbsyizrMedWIacFS5Di.jpg",
                    MenuId = tortillas.Id
                });
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Chimichanga",
                    Description = "Пикантен оброк од три тортиљи полнети со ориз, два вида кашкавал, халапењос и избор од пилешко, свинско или телешко месo, зачинет со цимет",
                    Price = 510.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/OSchhbdyQcNpOG0GeOvvoTw7qVnA6Phb.jpg",
                    MenuId = tortillas.Id
                });
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Nachos Enchilada",
                    Description = "Вкусен и сочен оброк со две тортиљи полнети со растопен кашкавал, пикантен начос кашкавал и пилешко или телешко месо, сервирано со пико де гајо",
                    Price = 630.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/jkhrEDMHdjsdltsBQiBvr6n7bdNUgEZb.jpg",
                    MenuId = tortillas.Id
                });
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Flautas",
                    Description = "Три крцкави тортиљи полнети со фета сирење и пилешко филе, сервирани со пико де гајо",
                    Price = 490.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/wiqpzCoFl6AvHNxCirvGRSXCH30Cnbvo.jpg",
                    MenuId = tortillas.Id
                });
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Tаmpico",
                    Description = "Вкусен специјалитет од ориз со печени зеленчуци, печурки, кашкавал и пилешко филе, сервирано во крцкава тортиља со салса и крем сос",
                    Price = 510.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/B8sbQvc2WfekoP6uFl8e5tYMbNbxH5l7.jpg",
                    MenuId = tortillas.Id
                });
                tortillas.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Espinacas Chimichanga",
                    Description = "Мексикански специјалитет, домашно тесто полнето со спанаќ, печурки и кромид, сервиран со пико де гајо",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/Msmb7NJGFvu42f5c4ToOyv5TKIDSDQtQ.jpg",
                    MenuId = tortillas.Id
                });
                restaurant.Menus.Add(tortillas);

                // Section: Specials 🥩🥘
                var specials = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Specials 🥩🥘",
                    RestaurantId = restaurant.Id
                };
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Amigos Chicken",
                    Description = "Пикантно пилешко филе приготвено со микс од зеленчуци, сервирано со компир",
                    Price = 510.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/u5xIzDUEbnLwhMjyvRKhUxdOCN0NN8YT.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Garlic-sage Chicken",
                    Description = "Сотирано пилешко филе приготвено со жалфија и лук, сервирано со компир",
                    Price = 450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/OEp1fNZRwHE0uYVhrnZ8rPcrttUdfSmm.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Parma Chicken",
                    Description = "Поховано пилешко филе прелиено со доматен сос и моцарела, сервирано со компир",
                    Price = 610.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/wxgeLFFQwOnrigioCisJm2W0dut69IZ5.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Herb-pork Saute",
                    Description = "Сотирано свинско филе приготвено со микс од ароматични тревки, сервирано со компир",
                    Price = 750.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/whk3ku30zcqHKelcfFWXPkXp6iBwkHUm.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Porcini pork",
                    Description = "Сотирано свинско филе прелиено со кремаст сос од вргањ, сервирано со компир",
                    Price = 810.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/QcOquryp14KHNJWUP9RNyRM0dZcWEDtf.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Summer Paella",
                    Description = "Морски плодови готвени на путер со зачинет ориз, зеленчук, лук, шафран и други зачини",
                    Price = 990.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/ZIsLziqrilwX3LtjUDir9bxdZbh51W0T.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Pepper Beef",
                    Description = "Сотиран бифтек прелиен со кремаст сос од шарен бибер, сервиран со компир",
                    Price = 1650.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/JAQjiesPtuK5jtLE1jufdGfKWziWoNJ6.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Rosemary Beef",
                    Description = "Сотиран бифтек прелиен со топол сос од рузмарин, лук и маслиново масло, сервиран со компир",
                    Price = 1450.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/iD6NaQwwzvIBTzBPjgns8UOsDgwzXVY4.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Chilli Con Carne",
                    Description = "Пикантно бавно печено јунешко месо прелиено со кашкавал, сервирано врз ориз со чипс, салца, и павлака",
                    Price = 790.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/wJjaZf0drr1h5GURYZ6wcwL6DRczVXPs.jpg",
                    MenuId = specials.Id
                });
                specials.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Grilled Porcini",
                    Description = "Сотиран вргањ на путер, хумус, шери домат, лук, интегрален леб, микросалата",
                    Price = 550.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/8lcrdhpQKMvTjIZftmaMigLg1MkyvnsW.jpg",
                    MenuId = specials.Id
                });
                restaurant.Menus.Add(specials);

                // Section: Desserts 🍮
                var desserts = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Desserts 🍮",
                    RestaurantId = restaurant.Id
                };
                desserts.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Choco Frita",
                    Description = "Крцкави тортиљи полнети со растопено чоколадо и лешници",
                    Price = 280.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/wbiead93SnR2f8sf67gPKkWPnSOBwMkn.jpg",
                    MenuId = desserts.Id
                });
                desserts.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Creme Brulee",
                    Description = "Богат млечен крем покриен со крцкава карамела",
                    Price = 280.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/3H5p2bnYM2EeOLv5ghKD5L9gUN3e1pX1.jpg",
                    MenuId = desserts.Id
                });
                desserts.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Apple Burrito",
                    Description = "Тортиља полнета со јаболка и ореви, зачинета со цимет, сервирана со сладолед од ванила",
                    Price = 280.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/brgf7DyJBVDYb5TmwnMgbAWnp06vtp3j.jpg",
                    MenuId = desserts.Id
                });
                desserts.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Lava Cake",
                    Description = "Топол колач полнет со растопено чоколадо сервиран со сладолед",
                    Price = 280.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/SBHBvFSDiQs2Bux4Vdor0pYYB1bZdyi0.jpg",
                    MenuId = desserts.Id
                });
                desserts.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Churros",
                    Description = "Традиционални Мексикански тулумби сервирани со топено чоколадо",
                    Price = 280.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/CcUSldUtNFrFOwHkxGEbkkKyfrvDit2Y.jpg",
                    MenuId = desserts.Id
                });
                desserts.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Munchmallow Wrap",
                    Description = "Tортиља полнета со путер од кикирики, крем од бело чоколадо и манчмалоу, сервирана со сладолед",
                    Price = 280.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/KWJPZgsgF6ZCNpZtLO8LO99cicGK5sg3.jpg",
                    MenuId = desserts.Id
                });
                desserts.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Peanutbutter Cheesecake",
                    Description = "Чизкејк со маскарпоне, кикирики, путер од кикирики, бисквити и чоколадо",
                    Price = 280.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/QzlTYu22vbK5dYclbclrA7H1zK1IvC6W.jpg",
                    MenuId = desserts.Id
                });
                restaurant.Menus.Add(desserts);

                restaurantList.Add(restaurant);
            }

            // === Amigos Ljubljanska ===
            {
                var restaurant = new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Amigos Ljubljanska",
                    Description = "Доставуваме до Вашата врата",
                    StreetAddress = "",
                    City = "Skopje",
                    ImageUrl = "https://korpa.ba/restaurant_uploads/58uf5cfYp70Ai50SkHyIknzFtu2LKg4E.jpg",
                    Category = "Mexican",
                    DeliveryPrice = 25
                };

                // Section: BURGER DAY! 🍔🍟
                var burgerDay = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "BURGER DAY! 🍔🍟",
                    RestaurantId = restaurant.Id
                };
                burgerDay.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Burger \"Masin\"",
                    Description = "Уметничко дело пресликано во гурмански оброк со изобилство на вкусови. 100% јунешки бургер печен на оган, во бриош лепче, помфрит од сладок компир, пармезан, сув домат и пикантен чипотле сос. (Се служи и вегетаријански)",
                    Price = 630.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/FsOHENeKYPTA5pg8J2xoUAjnTq7KaCpL.jpg",
                    MenuId = burgerDay.Id
                });
                burgerDay.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Burger Amigos",
                    Description = "100% јунешки бургер во бриош лепче, начос сос, гвакамоле, крцкава сланина, домат, кромид, ајсберг и чипотле",
                    Price = 630.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/fQwfsWw392WbZBGssajLWQHdWyj4QckS.jpg",
                    MenuId = burgerDay.Id
                });
                burgerDay.Items.Add(new MenuItem
                {
                    Id = Guid.NewGuid(),
                    Name = "Veggie Burger",
                    Description = "Ќофте од наут, морков, куркума, ајзберг, сув домат, карамелизиран кромид, пармезан, домат, сенф, бриош лепче, сервиран со помфрит од сладок компир и чипотле сос",
                    Price = 550.00m,
                    ImageUrl = "https://www.korpa.ba/product_uploads/l1B68Dz6WSlzuWLxOUU9lNLPSWrTZLHc.jpg",
                    MenuId = burgerDay.Id
                });
                restaurant.Menus.Add(burgerDay);

                // Section: Breakfast 🍳
                var breakfast = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Breakfast 🍳",
                    RestaurantId = restaurant.Id
                };
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Amigos Breakfast", Description = "Здрав појадок со две јајца на око, гвакамоле, рукола, интегрален леб, крем сос и пршута", Price = 370.00m, ImageUrl = "https://www.korpa.ba/product_uploads/vUZ5jW4d7JJDrdoQRFfZq5LRDgYuJfOY.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Breakfast Burrito", Description = "Топол тортиља врап полнет со пржени јајца, гвакамоле, едамер и по избор сланина или мешан зеленчук", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/BKTecszf1RkvTLBKKwLxTONFPWZFU1n4.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Avocado Humus", Description = "Две интеграални лепчиња сервирани со гвакамоле, хумус, јајце и лајм", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/0uTl2N8BWA2GrF8CjXHXdSOfyKMm2fza.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Wrap", Description = "Тортиља врап полнет со пилешко филе, печени зеленчуци, кашкавал, печурки и фрижол", Price = 270.00m, ImageUrl = "https://www.korpa.ba/product_uploads/TT1kgOuuVLuib7IVEKGOU6SAjNZj23nX.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Eggs Benedict", Description = "Две поширани јајца сервирани со лебче и сланина, прелиени со холандез сос", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/aDYVtF0XjBABQP2BgxPtC3dSxtISvZfB.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Amigos Toast", Description = "Тортиља полнета со кашкавал и избор од сланина или печурки, сервирана со зачинет компир, крем сос и салса", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/81Ekbd00utv5MBgYpAeZFg8ErIBQqbep.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Huevo Rancheros", Description = "Традиционален Мексикански појадок со две пржени јајца сервирани врз две тортиљи збогатени со колбас, авокадо, фета сирење и пико де гајо", Price = 320.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ddyePdkY4v4Thhzama3ymZKgljCX8NUr.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Pancakes", Description = "Пет американски палачинки сервирани со крем од маскарпоне и путер од кикирики, јаворов сируп и сезонско овошје", Price = 370.00m, ImageUrl = "https://www.korpa.ba/product_uploads/tmFKQ4WBpGxvmglQqJHCsHfDldbfR3xm.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Omelette", Description = "Омлет со 3 јајца полнет по избор со кашкавал и сланина / кашкавал и печурки", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/u9dvo6lVjVrxh0rUYx04neyHCwnFm5HG.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Ljubljanska Sandwich", Description = "Бриош лепче, козјо сирење, авокадо, цвекло, рукола, мед, сенф во зрно, зачинет компир и афион", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ygo0wcPPaHfhB1Drgnr2KERP3hvTyXFL.jpg", MenuId = breakfast.Id });
                breakfast.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Salmon Sandwich", Description = "Интегрално лепче премачкано со песто, димен лосос, домат, рукола, кромид, сервиран со компири", Price = 340.00m, ImageUrl = "https://www.korpa.ba/product_uploads/bnZLpUVjAuvxKdN4Lu69lOXvMZBfOPjD.jpg", MenuId = breakfast.Id });
                restaurant.Menus.Add(breakfast);

                // Section: To Share 🥰
                var toShare = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "To Share 🥰",
                    RestaurantId = restaurant.Id
                };
                toShare.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Nachos", Description = "Тотопос прелиен со топен едамер и пикантен начос кашкавал, сервиран со салса и крем сос", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/hDLlyORenRGpghgjzFtxLEkYNnqVJEWj.jpg", MenuId = toShare.Id });
                toShare.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Guacamole", Description = "Свежа кремаста салата од авокадо зачинета со свежи домати, кромид, лимета и коријандер, сервирана Мексикански чипс", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/dkvV2Hr9RNDNErymk8vZuNmzP2vSjiNj.jpg", MenuId = toShare.Id });
                toShare.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Totopos Ljubljanska", Description = "Чипс од пченкарна тортиља сервиран со салса, крем сос, начос кашкавал и пико де гајо", Price = 410.00m, ImageUrl = "https://www.korpa.ba/product_uploads/CRgjJLGqZ3ouRx9nFagLts1EUCg7UMWI.jpg", MenuId = toShare.Id });
                toShare.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Roll de pollo", Description = "Пилешко филе во крцкава тортиља сервирано со крем сос", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ZwsJyce5faHgCoLsmZ6YNxgXZTFqpcEC.jpg", MenuId = toShare.Id });
                toShare.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Hummus", Description = "Кремаста салата од наут, лук, таан, лимон и маслиново масло, сервирана со крцкава тортиља", Price = 410.00m, ImageUrl = "https://www.korpa.ba/product_uploads/iEZqxt6zfLt3xfcV8JbtkaLbnUzfW3Ik.jpg", MenuId = toShare.Id });
                toShare.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Salmon Roll", Description = "Тортиља, крем сос, лосос, авокадо, спанаќ, киноа, дресинг", Price = 620.00m, ImageUrl = "https://www.korpa.ba/product_uploads/SMIX91dm8FgZIVZpct9x2gYA2274hUrz.jpg", MenuId = toShare.Id });
                toShare.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Sweet Potato Fries", Description = "Зачинет пржен сладок компир сервиран со пикантен чипотле дресинг", Price = 370.00m, ImageUrl = "https://www.korpa.ba/product_uploads/yXRpTSBKRnotytXbQYWsxajsPmi0DdZg.jpg", MenuId = toShare.Id });
                toShare.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Crispy Goat Cheese", Description = "Коцки козјо сирење со афион, послужени со џем од пиперки", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/sYU3EkiK0zksLCZnB55ABJT5IDTXIUQg.jpg", MenuId = toShare.Id });
                restaurant.Menus.Add(toShare);

                // Section: Tacos 🌮
                var tacos = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Tacos 🌮",
                    RestaurantId = restaurant.Id
                };
                tacos.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Carnitas Taco", Description = "Пикантно бавно печено цепкано свинско месо, кромид, начос кашкавал, фрижол, коријандер и пико де гајо", Price = 510.00m, ImageUrl = "https://www.korpa.ba/product_uploads/iflIg5dExaqTUnLs9rsvrWBxIKwiRlid.jpg", MenuId = tacos.Id });
                tacos.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Chilli Taco", Description = "Традиционално подготвено пикантно телешко месо, начос кашкавал, пико де гајо, свеж коријандер", Price = 550.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Msia0UkdTUcic0GlqAntAwDs8LHzfd2t.jpg", MenuId = tacos.Id });
                tacos.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Pollo Taco", Description = "Пилешки надкопан, лимета, халапењос, колслау салата и авокадо", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ns441lsx1duqDzZi8e2UYwyjibIA8WUe.jpg", MenuId = tacos.Id });
                tacos.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Avocado Taco", Description = "Печен сладок компир со сос од авокадо, црвен кромид, црвен грав и салата", Price = 470.00m, ImageUrl = "https://www.korpa.ba/product_uploads/UXSZdqhskTnOWNWQTqcRDsg5LNm6lRIM.jpg", MenuId = tacos.Id });
                tacos.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Shrimp Taco", Description = "Ракчиња, авокадо, црвен кромид, дресинг, ајсберг", Price = 650.00m, ImageUrl = "https://www.korpa.ba/product_uploads/MW4TdR4bKiTJoV5j0ffouoAoWSznjned.jpg", MenuId = tacos.Id });
                tacos.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Classic Taco", Description = "Нашиот препознатлив такос со кашкавал, начос кашкавал, ориз и месо по избор, сервиран со салса и крем сoс", Price = 510.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Do1cPxpA6ELCDrS50nx1IDdnSR8nxYew.jpg", MenuId = tacos.Id });
                restaurant.Menus.Add(tacos);

                // Section: Specials ✨
                var specials = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Specials ✨",
                    RestaurantId = restaurant.Id
                };
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Carnitas Special", Description = "Бавно печено, зачинето свинско месо сервирано со гвакамоле, пико де гајо, фижол, ајсберг и лимета и топли тортиљи (Совршено за двајца)", Price = 950.00m, ImageUrl = "https://www.korpa.ba/product_uploads/r9mFXY7qnffVe8DqIwu2UC19Tejdm4PV.jpg", MenuId = specials.Id });
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Chili Con Carne", Description = "Пикантно бавно печено јунешко месо прелиено со кашкавал, сервирано врз пире од сладок компир со чипс, салца, и павлака", Price = 790.00m, ImageUrl = "https://www.korpa.ba/product_uploads/98wJqRMTYaLQamFecjhrYr8HZUxNKo4U.jpg", MenuId = specials.Id });
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Summer Paella", Description = "Морски плодови готвени на путер со зачинет ориз, зеленчук, лук, шафран и други зачини", Price = 990.00m, ImageUrl = "https://www.korpa.ba/product_uploads/w5Afl8zaadgVEY19iMBphSedfnyotoR9.jpg", MenuId = specials.Id });
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Marocan Chicken", Description = "Специјалитет од зачинет пилешки надкопан сервиран со хумус, фалавел и колслоу", Price = 650.00m, ImageUrl = "https://www.korpa.ba/product_uploads/dPShDl6o5tljO23QGknIfR3YytJN6b5i.jpg", MenuId = specials.Id });
                restaurant.Menus.Add(specials);

                // Section: Grill 🥩
                var grill = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Grill 🥩",
                    RestaurantId = restaurant.Id
                };
                grill.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Beef Grill", Description = "Маринирано јунешко месо печено на оган сервирано со пире од сладок компир, колслоу и микросалата", Price = 1590.00m, ImageUrl = "https://www.korpa.ba/product_uploads/EZfmedMKIx9b4It5U1oWKUODul21aFhj.jpg", MenuId = grill.Id });
                grill.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Pork Grill", Description = "Маринирано свинско филе печено на оган сервирано пире од сладок компир, колслоу и микросалата", Price = 750.00m, ImageUrl = "https://www.korpa.ba/product_uploads/YgKlQavDsNE2PRAPdqb4pAWps20tfyX2.jpg", MenuId = grill.Id });
                grill.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Chicken Grill", Description = "Маринирано пилешко месо печено на оган сервирано со пире од сладок компир, колслоу и микросалата", Price = 510.00m, ImageUrl = "https://www.korpa.ba/product_uploads/WWkKx0MSWBuSNFTlxMNjHfh9i9U73IL7.jpg", MenuId = grill.Id });
                grill.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Baby Ribs", Description = "Зачинети пикантни свински ребренца маринирани во барбикју сос со зачини, печени на тивок оган, сервирани со пире од сладок компир, колслоу и чипотле сос", Price = 690.00m, ImageUrl = "https://www.korpa.ba/product_uploads/z7hhMkEO2jD6YJBsLbkXY2W6U7AgnkgI.jpg", MenuId = grill.Id });
                grill.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Burger \"Masin\"", Description = "Уметничко дело пресликано во гурмански оброк со изобилство на вкусови. 100% јунешки бургер печен на оган, во бриош лепче, помфрит од сладок компир, пармезан, сув домат и пикантен чипотле сос. (Се служи и вегетаријански)", Price = 630.00m, ImageUrl = "https://www.korpa.ba/product_uploads/gVYwkzY9dyCP6QA4bq1VABFiocH1d4iy.jpg", MenuId = grill.Id });
                grill.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Octopus", Description = "Октопод печен на оган сервиран со сладок компир, спанаќ и лајм", Price = 1800.00m, ImageUrl = "https://www.korpa.ba/product_uploads/VsdNOZGWwrZ7HmvKCBoGEtxkos0Kfb9m.jpg", MenuId = grill.Id });
                grill.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Burger Amigos", Description = "100% јунешки бургер во бриош лепче, начос сос, гвакамоле, крцкава сланина, домат, кромид, ајсберг и чипотле", Price = 630.00m, ImageUrl = "https://www.korpa.ba/product_uploads/DZ9RBXvyFiQnZP4mV6qsnk0LQK07prQY.jpg", MenuId = grill.Id });
                grill.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Rosemary Beef", Description = "Таљата бифтек прелиен со топол сос од рузмарин, лук и маслиново масло, сервиран со пире од сладок компир и микросалата", Price = 1450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xWE0CQUSu8r5f0DNLjuxFot7Kig0yMXa.jpg", MenuId = grill.Id });
                restaurant.Menus.Add(grill);

                // Section: Classics 🌯
                var classics = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Classics 🌯",
                    RestaurantId = restaurant.Id
                };
                classics.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Quesadilla", Description = "Традиционален Мексикански оброк од две тортиљи полнети со растопен кашкавал и ваш избор од пилешко филе, печурки или печени зеленчуци, сервиран со салса и крем сос", Price = 470.00m, ImageUrl = "https://www.korpa.ba/product_uploads/XJrNS98FCU4C2rC93bcfTxXw1FmPD2a3.jpg", MenuId = classics.Id });
                classics.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Burrito", Description = "Голема тортиља полнета со ориз, начос кашкавал, едамер, крем сос и ваш избор од пилешко филе, телешки рамстек или мешани зеленчуци, сервирано со салса", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/GzTECGL8GWjFL8J7bUHIKDsBSfx38p8c.jpg", MenuId = classics.Id });
                classics.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Fajitas", Description = "Ваш избор од пилешко, телешко, или свинско месо, припремено со микс од зеленчуци и растопен кашкавал, послужено со свежа салата, шест тортиљи, ориз, пико де гајо, салса и крем сос (Совршено за двајца)", Price = 950.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Xkkfb3563sJRTuteVW3xl2Q3Xc8Y2VeJ.jpg", MenuId = classics.Id });
                classics.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Nachos Enchilada", Description = "Вкусен и сочен оброк со две тортиљи полнети со едамер, пикантен начос кашкавал и пилешко или телешко месо", Price = 630.00m, ImageUrl = "https://www.korpa.ba/product_uploads/SenMbaFGSlvjxoyBsCMnaP3XafMOnpAA.jpg", MenuId = classics.Id });
                classics.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Flautas", Description = "Три крцкави тортиљи полнети со фета сирење и пилешко филе, сервирани со пико де гајо", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/SlldREh6ewsTImvkvUejAZgGZWGzMR4j.jpg", MenuId = classics.Id });
                restaurant.Menus.Add(classics);

                // Section: Vege 🌿
                var vege = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Vege 🌿",
                    RestaurantId = restaurant.Id
                };
                vege.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Falafel", Description = "Топчести ќофтиња од наут, кромид, морков и магдонос, сервирани со авокадо дресинг, колслоу и хумус", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/CNSHHqw9vXwbgwfBzj1dRdA5or6JZ9Rr.jpg", MenuId = vege.Id });
                vege.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Tampico Veggie", Description = "Ориз со печени зеленчуци, печурки, и кашкавал, сервирани во топла тортиља со салса и крем сос", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/duiIXf65gEt1tVoXs6AMOpqtqsir8euJ.jpg", MenuId = vege.Id });
                vege.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Porcini", Description = "Сотиран вргањ на путер, хумус, шери домат, лук, интегрален леб, микросалата", Price = 550.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xcBRixE8iKA0NznWdQHMvMjzuQtPxud3.jpg", MenuId = vege.Id });
                vege.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Veggie Burger", Description = "Ќофте од наут, морков, куркума, ајзберг, сув домат, карамелизиран кромид, пармезан, домат, сенф, бриош лепче, сервиран со помфрит од сладок компир и чипотле сос", Price = 550.00m, ImageUrl = "https://www.korpa.ba/product_uploads/MIW8wLyh4zDiycP23iRZ1ArgwKusGemf.jpg", MenuId = vege.Id });
                restaurant.Menus.Add(vege);

                // Section: Salads 🥗
                var salads = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Salads 🥗",
                    RestaurantId = restaurant.Id
                };
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Ljubljanska Salad", Description = "Микс зелена салата, горгонзола, сладок компир, авокадо и карамелизиран орев зачинета со дресинг од маслиново масло, мед и лимон", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Zh4AlnOyIdYTJthmw30BQnfFPntbTC7p.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Amigos Salad", Description = "Нашата препознатлива салата од марула, сецкано пилешко филе и печурки, гарнирана со пармезан, маслинки и вкусен дресинг", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/kN9iPrj9NyBE3ffKMKRzfDLMLympU6gI.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Quinoa Salad", Description = "Салата со киноа, црвен кромид, пиперка, грашак, грав и пченка, зачинета со дресинг од маслиново масло, сенф и лимон", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/2iN3EllrT4Iq8GAqkrKBwR1hHbKKHc6G.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Beef Salad", Description = "Сотиран бифтек сервиран врз рукола, шери домат и пармезан прелиено со балсамико дресинг", Price = 850.00m, ImageUrl = "https://www.korpa.ba/product_uploads/uXcQDIT12ALZOb0UbkmzHNtwRTYwls2w.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Goat Cheese Salad", Description = "Вкусна салата со свеж спанаќ, авокадо, поховано козјо сирење, лешници, домати, маслинки и крема балсамико", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Dk5XVTSqf42xALqetJX8aei5rmjpMv99.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Caesar Salad", Description = "Традиционална Цезар салата со марула, ајсберг, пилешко филе, тостиран леб, и пармезан, прелиена со цезар дресинг", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/exwFY5PWvoA2i0YUgEWk9jAYDR50wZiF.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Cobb Salad", Description = "Здрава протеинска салата со авокадо, пилешко филе, варено јајце, домати и крцкава сланина, сервирани врз марула и рукола со дресинг од мед и сенф", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/pmNcb6dHFr5lYwXQIJ0JZGbtVXBhXBVY.jpg", MenuId = salads.Id });
                restaurant.Menus.Add(salads);

                // Section: Desserts 🍮
                var desserts = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Desserts 🍮",
                    RestaurantId = restaurant.Id
                };
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Choco Frita", Description = "Крцкави тортиљи полнети со растопено чоколадо и лешници", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/QNjO3QoL8yWaebBssHIRwldWvRH5VS5k.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Peanutbutter Cheesecake", Description = "Чизкејк со маскарпоне, кикирики, путер од кикирики, бисквити и чоколадо", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/XMsEWkG3LfOHOq244oQpvZ3yPYYZmJsS.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Apple Burrito", Description = "Тортиља полнета со јаболка и ореви, зачинета со цимет, сервирана со сладолед од ванила", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/NVmtRIk91udTcjQHd3FBYMBMsFC0Fpcj.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Lava Cake", Description = "Топол колач полнет со растопено чоколадо сервиран со сладолед", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/k1zCyZiDBhnlOVr02Kl4V0idEk1QPh0G.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Churros", Description = "Традиционални Мексикански тулумби сервирани со топено чоколадо", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/10CBoPOybuPkE7Gc1hzDHXdJdU7rCs2t.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Churros Parfait", Description = "Млечен ладен крем со лешници и шумско овошје, сервиран врз плетенка од чурос", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ot1vDwuOBgKw6oArH7b9VGvdZp2xUxVX.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Pestinos", Description = "Пржени топчиња од путер-тесто, сервирани со карамелизирана праска, јаворов сируп и цимет", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/96XnI8lPqijOxkEyrTI5WjKamOO7K73w.jpg", MenuId = desserts.Id });
                restaurant.Menus.Add(desserts);

                restaurantList.Add(restaurant);
            }

            // === Amigos Zeleznicka === (matches Java exactly)
            {
                var restaurant = new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Amigos Zeleznicka",
                    Description = "Доставуваме до Вашата врата",
                    StreetAddress = "",
                    City = "Skopje",
                    ImageUrl = "https://korpa.ba/restaurant_uploads/bWHnrQtlO3bHFacmuEe1NjG7zTvs5ar3.jpg",
                    Category = "Mexican",
                    DeliveryPrice = 25
                };

                // Section: BURGER DAY! 🍔🍟
                var burgerDay = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "BURGER DAY! 🍔🍟",
                    RestaurantId = restaurant.Id
                };
                burgerDay.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Класик чизбургер", Description = "Блек ангус јунешка плескавица и чедар, врз лепче, сервирани со домати, корнишони, кромид, кечап и сенф, ајсберг, сладок компир, чипотле сос", Price = 690.00m, ImageUrl = "https://www.korpa.ba/product_uploads/5pXjnKgsKy9BC7xhZGu7iiBOf5pguIOa.jpg", MenuId = burgerDay.Id });
                burgerDay.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фета бургер", Description = "Блек ангус јунешка плескавица, кремасто зачинето фета сирење, свежи домати и краставица, сервирани со, сладок компир, чипотле сос.", Price = 690.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Rs4qH9rFBXyZM2bKmIVygc2zTbP6F4xz.jpg", MenuId = burgerDay.Id });
                burgerDay.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Железничка бургер", Description = "Блек ангус јунешка плескавица и сос од горгонзола врз лепче, со додаток на корнишони и сланина, сладок компир и чипотле сос", Price = 750.00m, ImageUrl = "https://www.korpa.ba/product_uploads/uz92RFciD1fmUuBo6v2VFg0OXWgN7jwB.jpg", MenuId = burgerDay.Id });
                burgerDay.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фалафел бургер", Description = "Фалафел плескавица врз лепче, ајсберг, домат и кромид со црвен хумус. Збогатен со кремасто зазики, слаток компир и чипотле сос.", Price = 610.00m, ImageUrl = "https://www.korpa.ba/product_uploads/L1kzdevI7swQlYcvoT30gd2MusDcowy6.jpg", MenuId = burgerDay.Id });
                restaurant.Menus.Add(burgerDay);

                // Section: Салати 🥗
                var salads = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Салати 🥗",
                    RestaurantId = restaurant.Id
                };
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Медитеранска салата со киноа", Description = "Свежа и хранлива салата со шери домати, краставички, црвен кромид, морков и ајсберг, комбинирана со црн наут и шарена киноа. Зачинета со освежителен лимонов дресинг", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/tmka922X0vpn9gsiADyzprXAnuwfCJlJ.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пољо салата", Description = "Печен пилешки копан, крцкав ајсберг, парчиња авокадо и шери домати и крцкави тортиљи.", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Cwj6b36l542jnxt3kos2BfPWeOgTkKyw.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Лосос салата", Description = "Свеж ајсберг и рукола, надополнети со резанки црвен кромид, маслинки и пржен лосос во афион, збогатени со капери, слатки пиперчиња и микротревки.", Price = 590.00m, ImageUrl = "https://www.korpa.ba/product_uploads/c0Q1ucDIiOl3wwTRqcpVMLv4LHX5AIy2.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бифтек салата", Description = "Салата со сочен бифтек, разни зеленчуци, ароматично нане, и рукола, дополнета со микс од печурки и лимонов дресинг", Price = 890.00m, ImageUrl = "https://www.korpa.ba/product_uploads/fdTnBb9TDMv89EZ9cVqb8JsaNB3ebvOj.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Дакос класик салата", Description = "Јачменов леб натопен во доматен пелат и домати, зачинет со маслиново масло, оригано, кромид парчиња, фета и маслинки.", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/w9ObcvOaOEmtQolEjLOORzkarHFdWIpT.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Железничка салата", Description = "Рукола и ајсберг, збогатени со слатко цвекло, кремаста фета, крцкави ореви и црни маслинки со лимонов дресинг", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/TCOmtV5huHJ1uD8VTMfCQBDsFIZv3xJW.jpg", MenuId = salads.Id });
                restaurant.Menus.Add(salads);

                // Section: Мезе 🧀
                var meze = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Мезе 🧀",
                    RestaurantId = restaurant.Id
                };
                meze.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Мароканско мезе", Description = "Селекција на хумус, послужен со маслинки, свежи краставици, маринирани артичоки, козјо сирење, урми и шери домати во две бои. Сервирано со топол леб, парченца лимон и крцкави фалафел топчиња.", Price = 950.00m, ImageUrl = "https://www.korpa.ba/product_uploads/l4OXmEZUnsIgoF3dd1USzRHegCiL3lKg.jpg", MenuId = meze.Id });
                meze.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Мексиканско мезе", Description = "Гвакамоле и кремаста кесадија со топен кашкавал, дополнети со начос кашкавал, свежа салса верде и пикантна Сан Маркос салса. Послужено со чипс од тортиља.", Price = 850.00m, ImageUrl = "https://www.korpa.ba/product_uploads/54pYgaltVs60dpHRPKcaHcWZTVUfqPaq.jpg", MenuId = meze.Id });
                meze.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Медитеранско мезе", Description = "Мешавина од кремасти салати од модар патлиџан, фета дип, и класичен зазики, послужени со маслинки и топла пита леб. Комплетирано со маринирани пиперчиња со туна и свеж лимон.", Price = 990.00m, ImageUrl = "https://www.korpa.ba/product_uploads/MVr9vvguv8Z9vK7WR9hIUdJ488zb9mYZ.jpg", MenuId = meze.Id });
                restaurant.Menus.Add(meze);

                // Section: Предјадења🍴
                var starters = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Предјадења🍴",
                    RestaurantId = restaurant.Id
                };
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фалафел врз црвен хумус", Description = "Четири крцкави фалафел топчиња, послужени со богат доматен хумус и дресинг од зазики, украсено со свежи микротревки", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/6clSqU7PNMKGrNranQ6J1oKBjPKrEZOU.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Сладок компир со чипотле", Description = "Зачинет пржен сладок компир сервиран со пикантен чипотле дресинг", Price = 370.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Wtv8JgTyTArexnP7tWqhjYgCUgByDYeY.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Ќофтиња од тиквичка со зазики", Description = "Сочни ќофтиња направени од тиквички, лесни и воздушни, послужени со освежителен зазики сос и фета", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/YgK7yXSfbBH117OXG8fhxDDsTfR5LfW5.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Шкампи темпура", Description = "Панирани шкампи, сервирани со кремаст аиоли сос", Price = 590.00m, ImageUrl = "https://www.korpa.ba/product_uploads/hkJSVcEIT7TJVm3nkGOVrAgY5PZ3cKOY.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Вргањ со хумус", Description = "Сотиран вргањ на путер, хумус, шери домат, лук, интегрален леб, микросалата", Price = 590.00m, ImageUrl = "https://www.korpa.ba/product_uploads/mFN0YCQ0gM8blWhAgiryobZex0458SN6.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Начос Железничка", Description = "Крцкав тортиља чипс, прелиен со начос кашкавал, пикантни халапењос, свежи домати, и кремаст фрижол. Сервирани со гвакамоле", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/XCiYnuigvMzOGWzodCTzPU15SW6FHl9X.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пикантна кесадија", Description = "Tортиља полнета со кремасто сирење фета, во придружба на кисела павлака, сочни шери домати, сечкани маслинки и свежа рукола", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/3Dmx6i3mEr4jA4z4dokgWKbLrx4ppg73.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Крцкаво козјо сирење", Description = "Коцки козјо сирење со афион, послужени со џем од пиперки", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/afMgIWURJsd1EaDjJj83nfK3JEUD9Lzn.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Флаутас со слатко чили", Description = "Две панирани тортиљи полнети со грилован батак , кашкавал, слатко чили и кромид.", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/WsWyKrzk4rRz8DpCSyWlTGes1pmqN7dg.jpg", MenuId = starters.Id });
                starters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фета Гвакамоле", Description = "Традиционално кремасто гвакамоле наросено со фета и корен од свеж анасон, сервирано со крцкава тортиља.", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/IgnqUWdFAJaE66nzLCN1zFz9KJgnOX6y.jpg", MenuId = starters.Id });
                restaurant.Menus.Add(starters);

                // Section: Специјалитети 🍖
                var specials = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Специјалитети 🍖",
                    RestaurantId = restaurant.Id
                };
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фахита со шарени бабури", Description = "Мариниран пилешки батак, сервиран со карамелизиран кромид и шарени бабури. Сервиран со топли тортиљи, гвакамоле, фрижол, течен начос и свеж лајм", Price = 960.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Pub1ZpcXVO9IKyYE1tg1rU3S997hDchs.jpg", MenuId = specials.Id });
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Домашно Рагу со њоки", Description = "Рагу од свинско и телешко месо послужено со њоки. Збогатено со рендан пармезан и свеж босилек", Price = 750.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ETQzUkXtCPCMeTK0Hmi7vJk2PpOlTm0W.jpg", MenuId = specials.Id });
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Рижото со вргањ", Description = "Класичено ризото со арботио ориз, збогатено со вргањ. Завршен со путер и рендан пармезан", Price = 610.00m, ImageUrl = "https://www.korpa.ba/product_uploads/YtKwMcViEnQYIpCoCrkIYZdPIBR19s8p.jpg", MenuId = specials.Id });
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Карне асада со чимичури сос и домашно гвакамоле", Description = "Сецкан јунешки рамстек, сервиран со чимичури и свежо гвакамоле, дополнет со микс од црвени и жолти шери домати и пикантни халапењоси. Сервирани со топли тортиљи и гвакамоле", Price = 1290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/t23Bg2ULr1aviwBnyoMSBTGk6c1i3o68.jpg", MenuId = specials.Id });
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Рижото со шафран", Description = "Кремасто ризото приготвен со арборио ориз и путер. Зачинет со шафран и комплетиран со рендан пармезан", Price = 590.00m, ImageUrl = "https://www.korpa.ba/product_uploads/4iZ07A7KFvJqqJdRqoT3atWPSihPyCUG.jpg", MenuId = specials.Id });
                specials.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Шиш кебап со три вида месо и хумус", Description = "Пилешки копан, свинско филе и бифтек печени на жар, сервирани со кремаст хумус, зазики и пита лепче", Price = 820.00m, ImageUrl = "https://www.korpa.ba/product_uploads/tEzHGZpRgnuZmvOXEEHzzpxKfJFwXjh4.jpg", MenuId = specials.Id });
                restaurant.Menus.Add(specials);

                // Section: Бургери 🍔
                var burgers = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Бургери 🍔",
                    RestaurantId = restaurant.Id
                };
                burgers.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фалафел бургер", Description = "Фалафел плескавица врз лепче, ајсберг, домат и кромид со црвен хумус. Збогатен со кремасто зазики, слаток компир и чипотле сос.", Price = 610.00m, ImageUrl = "https://www.korpa.ba/product_uploads/egugi6IYKMKNdtI6D0EiNDqJjTal3a3f.jpg", MenuId = burgers.Id });
                burgers.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Железничка бургер", Description = "Блек ангус јунешка плескавица и сос од горгонзола врз лепче, со додаток на корнишони и сланина, сладок компир и чипотле сос", Price = 750.00m, ImageUrl = "https://www.korpa.ba/product_uploads/r0xx41e0rhAsTy0aZCJZy2L02KS46jk8.jpg", MenuId = burgers.Id });
                burgers.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Класик чизбургер", Description = "Блек ангус јунешка плескавица и чедар, врз лепче, сервирани со домати, корнишони, кромид, кечап и сенф, ајсберг, сладок компир, чипотле сос", Price = 690.00m, ImageUrl = "https://www.korpa.ba/product_uploads/6SjNuvYIqfco7cvxe3IrVEZBzhM5oKeQ.jpg", MenuId = burgers.Id });
                burgers.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фета бургер", Description = "Блек ангус јунешка плескавица, кремасто зачинето фета сирење, свежи домати и краставица, сервирани со, сладок компир, чипотле сос.", Price = 690.00m, ImageUrl = "https://www.korpa.ba/product_uploads/OTvVD4Ns2Ly64MDd7fOOZ471Ti167nYR.jpg", MenuId = burgers.Id });
                restaurant.Menus.Add(burgers);

                // Section: Наполитанска пица 🍕
                var pizza = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Наполитанска пица 🍕",
                    RestaurantId = restaurant.Id
                };
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Маргарита пица", Description = "Доматен сос, моцарела, босилек, маслиново масло, пармезан", Price = 540.00m, ImageUrl = "https://www.korpa.ba/product_uploads/icbcn87oOf4xQ1AqwxXpnBIJff3s09Ac.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Прошуто и рукола пица", Description = "Доматен сос, моцарела, пармезан, рукола, пршута, шери домат", Price = 720.00m, ImageUrl = "https://www.korpa.ba/product_uploads/AsII4hqnpyTFikJikCJVGPvtyPlTPVWY.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Капричиоза пица", Description = "Доматен сос, моцарела, срца од артичоки, шунка, маслинки, пармезан и печурки", Price = 680.00m, ImageUrl = "https://www.korpa.ba/product_uploads/PvddoVmGP87UmYXS11nOSYtcKjylpm78.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Мортаца пица", Description = "Моцарела, мортадела, фстаци, пистачо паста робо, рикота и маслиново масло", Price = 680.00m, ImageUrl = "https://www.korpa.ba/product_uploads/aAKfBgYnxJjknhbDOFL8m2sCmClXgsBC.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Маринара пица", Description = "Доматен сос, лук, маслиново, шери робо, босилок", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/UEnoK5PqiYpyDJXICA2bJJjKmfnNGt1f.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Калцоне", Description = "Рикота, моцарела, пармезан, шунка и доматен сос", Price = 510.00m, ImageUrl = "https://www.korpa.ba/product_uploads/dWVXKspgScpYPeCm1NwMuYIBC0HkkJ96.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Чинкве формаџи пица", Description = "Моцарела, бри, горгонзола, пармезан, рикота", Price = 570.00m, ImageUrl = "https://www.korpa.ba/product_uploads/eAT80hNPloKyVSPl4KifjrfUGg7NSm5L.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Диавола пица", Description = "Доматен сос, моцарела, корте буена пиканте салама и пармезан", Price = 640.00m, ImageUrl = "https://www.korpa.ba/product_uploads/pa1r5Gi011daySai21OlkcXw6Qz7dL9R.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фунги и Тартуфо", Description = "Моцарела, пармезан, тартуфата, печурки, вргањ, маслиново масло", Price = 560.00m, ImageUrl = "https://www.korpa.ba/product_uploads/FYp1su1Wu1L2AugfcU7S1NgqKmBmw1q0.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Наполи пица", Description = "Доматен сос, моцарела, капери, инчуни, босилок", Price = 590.00m, ImageUrl = "https://www.korpa.ba/product_uploads/G4on9HdJ0xul6hnwFUtXd8cMCRB8lqje.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Буфалина пица", Description = "Доматен сос, биволска моцарела, свеж босилек", Price = 920.00m, ImageUrl = "https://www.korpa.ba/product_uploads/RbNO43WvRu1ELkwcBnUur9HdamC6Sz2U.jpg", MenuId = pizza.Id });
                pizza.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Брезаола пица", Description = "Доматен сос, моцарела, пармезан, рукола, брезаола, шери домат", Price = 830.00m, ImageUrl = "https://www.korpa.ba/product_uploads/KndP2kCnvSMqFoWaOENGXYh2R4PbqjX8.jpg", MenuId = pizza.Id });
                restaurant.Menus.Add(pizza);

                // Section: Мибраса скара 🔥
                var mibrasa = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Мибраса скара 🔥",
                    RestaurantId = restaurant.Id
                };
                mibrasa.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Аргентински рибај стек", Description = "Аргентински рибај стек печен на жар, сервиран со микс печен зеленчук и салата од цвекло и целер", Price = 2700.00m, ImageUrl = "https://www.korpa.ba/product_uploads/sHT8NnKnrrAYTPWiyXXTgmmgepgDYMWP.jpg", MenuId = mibrasa.Id });
                mibrasa.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Јунешки бифтек", Description = "Јунешки бифтек печен на жар, сервиран со микс печен зеленчук и салата од цвекло и целер", Price = 1790.00m, ImageUrl = "https://www.korpa.ba/product_uploads/QdfZcBT49DtyIt4uDA1UtszSHQtQ09Hz.jpg", MenuId = mibrasa.Id });
                mibrasa.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Свинско филе", Description = "Свинско филе печено на жар, сервирано со микс печен зеленчук и салата од цвекло и целер", Price = 790.00m, ImageUrl = "https://www.korpa.ba/product_uploads/6QXpCvjVrx2KDUe6eAzC3ixrlsqtlQ7l.jpg", MenuId = mibrasa.Id });
                mibrasa.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки батак", Description = "Пилешки батак печен на жар, сервиран со микс печен зеленчук и салата од цвекло и целер.", Price = 590.00m, ImageUrl = "https://www.korpa.ba/product_uploads/MwlfeNT38yON7JxJc4ZfOE2WhqFP23bb.jpg", MenuId = mibrasa.Id });
                mibrasa.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бејби свински ребра", Description = "Свински ребра печени на жар, сервирани со микс печен зеленчук и салата од цвекло и целер", Price = 1190.00m, ImageUrl = "https://www.korpa.ba/product_uploads/yw6twkrjvqjwXu0mzaOEUzB0RUr7yhTE.jpg", MenuId = mibrasa.Id });
                mibrasa.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Поркета", Description = "Маринирано, бавно печено роловано свинско месо, срвирано со микс печен зеленчук и кремаста салата од цвекло и целер", Price = 890.00m, ImageUrl = "https://www.korpa.ba/product_uploads/vXr5HnEHjTcyyvjAvtrpAY2hlfFkAXGE.jpg", MenuId = mibrasa.Id });
                restaurant.Menus.Add(mibrasa);

                // Section: Морско 🐙
                var seafood = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Морско 🐙",
                    RestaurantId = restaurant.Id
                };
                seafood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Шпански октопод со пире од целер", Description = "Октопод печен на жар, сервиран со пире од целер", Price = 1800.00m, ImageUrl = "https://www.korpa.ba/product_uploads/omY1RrFetvnUWgahxom1770Z1Q3TkQjx.jpg", MenuId = seafood.Id });
                seafood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Лосос со пире од целер", Description = "Лосос печен на жар, сервиран со пире од целер", Price = 1100.00m, ImageUrl = "https://www.korpa.ba/product_uploads/BNIf3z8VZT2hIfHhY1fTg56lmqeS9rRv.jpg", MenuId = seafood.Id });
                restaurant.Menus.Add(seafood);

                // Section: Додатоци 🍅
                var sides = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Додатоци 🍅",
                    RestaurantId = restaurant.Id
                };
                sides.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Печен зеленчук", Description = "", Price = 250.00m, ImageUrl = "https://www.korpa.ba/product_uploads/3SuszwRcjAz7ArxbATdLykzuqTIAsQHN.jpg", MenuId = sides.Id });
                sides.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пире од целер", Description = "", Price = 250.00m, ImageUrl = "https://www.korpa.ba/product_uploads/IEdqms5G3hqZ1WseMaOaTricHezfhSMe.jpg", MenuId = sides.Id });
                restaurant.Menus.Add(sides);

                // Section: Десерти 🥞
                var desserts = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Десерти 🥞",
                    RestaurantId = restaurant.Id
                };
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Чурос со чоколаден крем", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Meicmiy8yfw9jFIlBheVYvMCF6tbYfqs.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Баскијски чизкејк", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/arabngpBmcCCRyJX6VF1wiSxGGtUxudf.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Слатки њоки со ванила крем", Description = "", Price = 290.00m, ImageUrl = null, MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Профитерол со сорбе од малина", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/IkPUWuWNqngTK6kIOxyOsgeXJzxtkAxS.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пита со портокал со сладолед од ванила", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/NVSJSy9HzsmpzKNKLgqPotZFhf9OhYw1.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Чоколадна торта", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/OjZ1PepAHkaYSNLggXqayhH9WfLyiwUw.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Лава колач со фстак", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/DZX88f1ymuJX3DCnTFH21W95xqXko926.jpg", MenuId = desserts.Id });
                restaurant.Menus.Add(desserts);

                restaurantList.Add(restaurant);
            }

            // === Beer Garden Debar Maalo === (matches Java exactly)
            {
                var restaurant = new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Beer Garden Debar Maalo",
                    Description = "Доставуваме до Вашата врата",
                    StreetAddress = "",
                    City = "Skopje",
                    ImageUrl = "https://korpa.ba/restaurant_uploads/CzXlVP5pPXhTSEOBDaPormqc54Qave6j.jpg",
                    Category = "Bar & Grill",
                    DeliveryPrice = 25
                };

                // Section: Акциска понуда - храна 🍗🥨
                var promoFood = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Акциска понуда - храна 🍗🥨",
                    RestaurantId = restaurant.Id
                };
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Цезар салата 310 гр.", Description = "Марула, шери, пилешки стек, кубети, мајонез, коњак, павлака, сенф, пармезан, портокал", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/izgSVqGJQGIpwwRNKxTV544yilDcTGRn.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Похована даска 700 гр.", Description = "Зденки, едамер, крокети, моцарела, маслинки, кромид, пилешки прсти", Price = 1260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/GQJ3Zywf8F29qHHgaQ4b8TYQBNbwDx1V.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бир Гарден крилца 500 гр.", Description = "Пилешки крилца, зачин", Price = 340.00m, ImageUrl = "https://www.korpa.ba/product_uploads/KjHVjuupmEMhQunC5tD8xXLdU4P1sGbG.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "BBQ крилца 500 гр.", Description = "", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xCSkeWjBV2iVsP9ChY8DQt6K7nGmqWoT.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Лути крилца 500 гр.", Description = "", Price = 340.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Y08UKjcmKa7FWNug6J2Sf4lFPuCyeb4m.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки прсти 250 гр.", Description = "Пилешки стек, јајце, презла, сенф-мед сос, кану помфрит, сусам", Price = 360.00m, ImageUrl = "https://www.korpa.ba/product_uploads/K5CM9wKhKrL66fOJfHTLFNO5GTAtmqie.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бургер Чедар", Description = "Блек ангус телешка плескавица, лепче, домат, ајсберг, корнишони, мајонез, кари, кечап, чедар, бургер сос, кану помфрит", Price = 560.00m, ImageUrl = "https://www.korpa.ba/product_uploads/45zg3zA1639psHsMRQIlK2zY0MLc8GUe.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бургер Сланина", Description = "Блек Ангус телешка плескавица, лепче, домат, ајсберг, корнишони, зденка, свинска сланина, мајонез, кечап, кари, бургер сос, кану помфрит", Price = 580.00m, ImageUrl = "https://www.korpa.ba/product_uploads/QKtu16XRrF8pARhZZKg93EIp0DUiObCh.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Беер Гарден Микс Бургери", Description = "Блек Ангус телешка плескавица, лепчиња, домат, свинско ребро, ајсберг, корнишони, бургер сос, зденка, мајонез, кари, кечап, кану помфрит", Price = 680.00m, ImageUrl = "https://www.korpa.ba/product_uploads/zw2lw9BsCTxXQycm8letXac7Uw3LecVd.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Чикен бургер", Description = "Похован пилешки стек, лепче, домат, ајсберг, корнишони, кану помфрит, мајонез, кари, кечап, сусам", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/7ecIx0T3UqXF2ta73aFwAKJQtGJhlJAP.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Гурманска даска 1кг.", Description = "Виенска шницла, свинско ребро, плескавица, пилешки крилца, дебел колбас, тенок колбас, пекарски компир", Price = 1680.00m, ImageUrl = "https://www.korpa.ba/product_uploads/EMXsDxyyQOtyfL1FZC0iFgJnOcU8ICjY.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Беер Гарден колбас даска 1кг.", Description = "Кезе краинер, брат вурст, бернер вурс, тенок колбас мечка, дебел колбас мечка, тенок колбас атанасовски, пекарски компир", Price = 1480.00m, ImageUrl = "https://www.korpa.ba/product_uploads/2gNbpUpsV5HzMz12eTwsZKGxIYlml8Rm.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Тексас кременадла 650 гр.", Description = "Свинска кременадла, компир, шери, оригано, босилок, копар", Price = 1144.00m, ImageUrl = "https://www.korpa.ba/product_uploads/J75DXWNkyEuFmDW81KXKjiAkrSmqxf9n.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бејби Рибс 550 гр.", Description = "Свински ребра, компир, мед, соја сос, кечап, кафеав шеќер, ворчестер сос", Price = 690.00m, ImageUrl = "https://www.korpa.ba/product_uploads/2t2GNJyidyxDWzro1KALL2iOJYWe9dky.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Свинско филе Бир Гарден 400 гр.", Description = "Свинско филе, оригано, босилек, копар, компир, сенф", Price = 708.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xl2Bm5stuf5N9iOTF367ghPKgTIVouTk.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пивска Плескавица парче 1кг.", Description = "Мелено месо, свинско каре, свинско филе, компир", Price = 1150.00m, ImageUrl = "https://www.korpa.ba/product_uploads/JcdGlwKuUPIrOvkhqRvdLmzF6NgWYlKL.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Тенок колбас Атанасовски 200 гр.", Description = "Тенок свински колбас, сенф", Price = 320.00m, ImageUrl = "https://www.korpa.ba/product_uploads/moeKpqq4brIAMSvFZk3bXAg3Ca2yj1UO.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Дебел колбас Мечка 200 гр.", Description = "Дебел свински колбас, сенф", Price = 360.00m, ImageUrl = "https://www.korpa.ba/product_uploads/4J26E6K5Et2pZ31dmuaH1R21B37rAIuf.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кезе Крајнер 200 гр.", Description = "2 парчиња свински колбас, сенф", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/hripvutpYVTq5DloUQv9sKieVy7EZHWZ.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Брат Вурст 200 гр.", Description = "2 парчиња свински колбас, сенф", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Lk6QkqwpF7CR6F9BEWluWaQ7sqB4119H.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бернер Вурст 220 гр.", Description = "Австриска виршла, сланина, кашкавал, сенф", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/eSmRTwRR6NUqHv6XpKOzAJJiRPKKMWwA.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Беергарден Штека Ребро 850гр.", Description = "", Price = 1403.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Rx1OIXzDYiXMrdSPS4z8NRbZyqdQ4wjL.jpg", MenuId = promoFood.Id });
                promoFood.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Телешка кременадла 1кг", Description = "Телешки кременадли, зеленчук", Price = 2050.00m, ImageUrl = "https://www.korpa.ba/product_uploads/0K1nLvrFKzvZvk5C4pgPWAUwwSF0SsU8.jpg", MenuId = promoFood.Id });
                restaurant.Menus.Add(promoFood);

                // Section: Акциска понуда - пиво 🍺
                var promoBeer = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Акциска понуда - пиво 🍺",
                    RestaurantId = restaurant.Id
                };
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Augustiner Hell 0.5", Description = "", Price = 400.00m, ImageUrl = "https://www.korpa.ba/product_uploads/gTqavfcggI4mz41i9bYLdbMLr9CBOcLT.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Benedikter Weiss 0.5", Description = "", Price = 270.00m, ImageUrl = "https://www.korpa.ba/product_uploads/fC1ct13lK9KbgbNNrx31zFe8xvvkWZA1.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Benediktiner Hell 0.5", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/L6oh6B1kjGBXq6jcrqSFjhtGYWZdgzQN.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Bitburger 0.5", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/G1Ix38diPM9GxAtQan3gW7PRKS51YRpI.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Erdinger Weissbier 0.5", Description = "", Price = 300.00m, ImageUrl = "https://www.korpa.ba/product_uploads/7zOA3ckkVXsWHyzUjQ3T39UWTr2zRqio.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Franziskaner Dunkel 0.5", Description = "", Price = 270.00m, ImageUrl = "https://www.korpa.ba/product_uploads/zYxLGdT9Ee0I7ts5habVOWhTVoAzvgsD.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Franziskaner Weiss 0.5", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/DhWrnAkbWhFcyBVfoEDNG3nPaBIPOHzU.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Hasen Brau Ausburger non filtered 0.5", Description = "", Price = 330.00m, ImageUrl = "https://www.korpa.ba/product_uploads/bHsnjETXfNAPecVVl7AXcp7YSYBOD1A6.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Hasen Brau Dunkler Hase 0.5", Description = "", Price = 330.00m, ImageUrl = "https://www.korpa.ba/product_uploads/gLNcgqCFJKvHQVOqF0kXxLdukafyqlwc.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Hasen Brau Weiser Hase 0.5", Description = "", Price = 330.00m, ImageUrl = "https://www.korpa.ba/product_uploads/4FGfayy2Z2Zttxp4IC5CaGkjR8E9shiE.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Paulaner Munchener 0.33", Description = "", Price = 210.00m, ImageUrl = "https://www.korpa.ba/product_uploads/iRVzlVy1bC49ja67oAG5zs0w6nJNqMDE.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Paulaner Salvator 0.33", Description = "", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/W3QvGxdi6IBjdV9sEb7WTmRMUrJrWMBJ.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Paulaner Weiss 0.33", Description = "", Price = 220.00m, ImageUrl = "https://www.korpa.ba/product_uploads/KbYqu2zo6eWQkdI7Hl0GVj9fHj1l7aCK.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Paulaner Weissbier Dunkel 0.55", Description = "", Price = 270.00m, ImageUrl = "https://www.korpa.ba/product_uploads/GBRVtTb9pPKQou6GV7k3FYQ3p1GsxcXu.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Schofferhofer Heffewizen Dunkel 0.5", Description = "", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/bhXDO1RZujQwFRT3PfYFgFKmbfUa4WRX.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Schofferhofer Kristall Weizen 0.5", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/bf9s7tVN1ZssPVPHpdWEWl9xjEaecvHz.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Schofferhofer Weiss 0.5", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/8YzjY0V6ewH6A28vbWl1BM3MsqFb15sb.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Weihenstephaner Heffe Dunkel 0.5", Description = "", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/bhmHlzykvqkiTluAwMqJAxFlpvCfU2Yr.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Weihenstephaner Vitus 0.5", Description = "", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/CYQV8LtF9ESxRnu2xyJfnsJKFAKL6sTG.jpg", MenuId = promoBeer.Id });
                promoBeer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Weihenstephaner Weissbier 0.5", Description = "", Price = 330.00m, ImageUrl = "https://www.korpa.ba/product_uploads/SJQubwSEShWhLySX53tfptl0iJvR88mN.jpg", MenuId = promoBeer.Id });
                restaurant.Menus.Add(promoBeer);

                // Section: BURGER DAY! 🍔
                var burgerDay = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "BURGER DAY! 🍔",
                    RestaurantId = restaurant.Id
                };
                burgerDay.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бургер Чедар", Description = "Блек ангус телешка плескавица, лепче, домат, ајсберг, корнишони, мајонез, кари, кечап, чедар, бургер сос, кану помфрит", Price = 560.00m, ImageUrl = "https://www.korpa.ba/product_uploads/vGFw7nrpG7U1GpBunbKnuUbnB2HaFGCM.jpg", MenuId = burgerDay.Id });
                burgerDay.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бургер Сланина", Description = "Блек Ангус телешка плескавица, лепче, домат, ајсберг, корнишони, зденка, свинска сланина, мајонез, кечап, кари, бургер сос, кану помфрит", Price = 580.00m, ImageUrl = "https://www.korpa.ba/product_uploads/FpmKwEscEg8K1yrNeE5oeiA5NThryzsa.jpg", MenuId = burgerDay.Id });
                burgerDay.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Беер Гарден Микс Бургери", Description = "Блек Ангус телешка плескавица, лепчиња, домат, свинско ребро, ајсберг, корнишони, бургер сос, зденка, мајонез, кари, кечап, кану помфрит", Price = 680.00m, ImageUrl = "https://www.korpa.ba/product_uploads/U8HK2Ltqsao524UNrrLbvgmn2WJrbkm8.jpg", MenuId = burgerDay.Id });
                burgerDay.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Чикен бургер", Description = "Похован пилешки стек, лепче, домат, ајсберг, корнишони, кану помфрит, мајонез, кари, кечап, сусам", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/zIxc9gkxPUoFg7OkZNgea1yyQ1OSVeyC.jpg", MenuId = burgerDay.Id });
                restaurant.Menus.Add(burgerDay);

                // Section: Салати 🥗
                var salads = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Салати 🥗",
                    RestaurantId = restaurant.Id
                };
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Македонска салата 410 гр.", Description = "Домат, црвен кромид, пиперка, магдонос, сол, масло", Price = 210.00m, ImageUrl = "https://www.korpa.ba/product_uploads/vd2gatD2nfYogbyy3QqPGTEsosNLhBIH.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Витаминска салата 320 гр.", Description = "Зелена зелка, марула, морков, цвекло, краставица, јаболко, сончоглед, семки, шери", Price = 210.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Xnq5fOh0zVMWWFRCA7aC3zRMA0qXctcu.jpg", MenuId = salads.Id });
                restaurant.Menus.Add(salads);

                // Section: Ладни предјадења 🧀
                var coldStarters = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Ладни предјадења 🧀",
                    RestaurantId = restaurant.Id
                };
                coldStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Млечна даска 330 гр.", Description = "Овчо сирење, овчи кашкавал, бри сирење, рокфорт сирење, пармезан, сирење во кора", Price = 1100.00m, ImageUrl = "https://www.korpa.ba/product_uploads/qmk7l1CpLe5C6UmBlmPzrgfEAS4U8A0H.jpg", MenuId = coldStarters.Id });
                coldStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Сувомесната даска 400 гр.", Description = "Свинска пршута, панцета, говедска пршута, мортадела, домашен кулен, миланска салама, сремски колбас", Price = 1260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/H5ahqdDJcZ58sCFihP954AaPq4DSEfaF.jpg", MenuId = coldStarters.Id });
                coldStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Овчо сирење 100 гр.", Description = "", Price = 190.00m, ImageUrl = "https://www.korpa.ba/product_uploads/DyMOfbdeT2ycjIcdJYvmFT8V14daraLp.jpg", MenuId = coldStarters.Id });
                coldStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Овчи кашкавал 100 гр.", Description = "", Price = 320.00m, ImageUrl = "https://www.korpa.ba/product_uploads/GA1aWOKR5IU6gdTP9iknU3YDGYsvmXQ3.jpg", MenuId = coldStarters.Id });
                coldStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Бри сирење 125 гр.", Description = "", Price = 340.00m, ImageUrl = "https://www.korpa.ba/product_uploads/6DzWD5PQm3jkD7xuYHTJNuKg3RpCufRs.jpg", MenuId = coldStarters.Id });
                coldStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пармезан 100 гр.", Description = "", Price = 330.00m, ImageUrl = "https://www.korpa.ba/product_uploads/38SSwgqhtkJmo5Kk7XAdXviVZzsEm1J0.jpg", MenuId = coldStarters.Id });
                restaurant.Menus.Add(coldStarters);

                // Section: Топли предјадења 🍟
                var hotStarters = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Топли предјадења 🍟",
                    RestaurantId = restaurant.Id
                };
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Похован кашкавал едамер", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/mNIANnlBbwAbR3nAiKKDglVwxrHZMpjM.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Похован кромид", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/q7PrKVvYkn0NvymSVrxAI61zq84WN6C4.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Похована моцарела", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/JXcXiAGKGVyDvK4HWQUAe7rVxLEU8n11.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Поховани крокети со печурки", Description = "", Price = 230.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ShfriVXX6sXVRGMw8B8umkAE8bhAchkO.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Тиквички чипс", Description = "", Price = 250.00m, ImageUrl = "https://www.korpa.ba/product_uploads/UAk3DK9iRdAIRiiJNJbo4R6n0tUed62N.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Сланина свинска чипс", Description = "", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/zLCg6VDk8LSYbdrjQasnPwUpCpwYX5Z9.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Сирење во кора", Description = "Кравјо сирење, кашкавал, зденка, кора", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Cj83LE6LiibnbRpi1gbytqwR6RskqtGX.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Тортиљи со пилешко", Description = "Пилешки стек, тортиљи", Price = 330.00m, ImageUrl = "https://www.korpa.ba/product_uploads/mSwydF9bBNwMMPds5FpGcPfRnIMSOKWS.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Помфрит 200 гр.", Description = "", Price = 170.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Zxztoruh6nQ5mlNOjJxRJ5ifNfi2ElpC.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Помфрит Беер Гарден 200 гр.", Description = "Помфрит, лук, оригано, путер", Price = 200.00m, ImageUrl = "https://www.korpa.ba/product_uploads/mgK4Y6D8lij2vKUf65wgE5MvK4rFAy5z.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кану помфрит 200 гр.", Description = "", Price = 180.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Y6VCuRoejgIrmRCQKheBTLsGkRTY28zc.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Помфрит со сирење 200 гр.", Description = "", Price = 210.00m, ImageUrl = "https://www.korpa.ba/product_uploads/3hrplZZlSWnFNnlUZgnSs28tgaKqnmAH.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пекарски компир со зачини 200 гр.", Description = "", Price = 180.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Z9Lvqpsq3GHvNAsmUNVsB2BxEQFWcYSV.jpg", MenuId = hotStarters.Id });
                hotStarters.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пивски помфрит 250 гр.", Description = "Помфрит, свинско ребро, кашкавал, кечап", Price = 360.00m, ImageUrl = "https://www.korpa.ba/product_uploads/u5FGe2Oe67zjiUH6RdisqbX4yAV7uWxG.jpg", MenuId = hotStarters.Id });
                restaurant.Menus.Add(hotStarters);

                // Section: Главни јадења 🍖
                var mains = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Главни јадења 🍖",
                    RestaurantId = restaurant.Id
                };
                mains.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Виенска шницла свинска 400 гр.", Description = "", Price = 530.00m, ImageUrl = "https://www.korpa.ba/product_uploads/urnTOtMYA3bDCaFLhJKCIXH3tr64sZIU.jpg", MenuId = mains.Id });
                mains.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Беер Гарден шницла 620 гр.", Description = "Свинско каре, јајца, презла, компир, тартар сос", Price = 990.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ZUZZx9N90qPrKpoCkrd9mz0yz4uGaNG9.jpg", MenuId = mains.Id });
                mains.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Виенска шницла мисиркина 400 гр.", Description = "Мисиркин стек, јајца, презла, помфрит, тартар сос", Price = 590.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xn3cR3bhUR1pXBG9qJOs8vpFMJhvNAdM.jpg", MenuId = mains.Id });
                mains.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Плескавица свинска 300 гр.", Description = "Мелено свинско месо, компир", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/AR7P3dQJZVCyYjpx3NvJCRjoMFj6S1Qp.jpg", MenuId = mains.Id });
                mains.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Плескавица телешка 300 гр.", Description = "Мелено телешко месо, компир", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/cQW8LlwHkR8BCxhqnFPhGSQrNKI6R6Ni.jpg", MenuId = mains.Id });
                restaurant.Menus.Add(mains);

                // Section: Пиво 🍺
                var beer = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Пиво 🍺",
                    RestaurantId = restaurant.Id
                };
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Heineken 0.33", Description = "", Price = 220.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Hlv4kjFRQqhsrZ37vAAUwBRuSNRE7Fgq.png", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Heineken 0.0% 0.33", Description = "", Price = 220.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xLIn2kFnUZ6GpNkFAUhaJY0PRmhWxoAQ.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Leffe Blond 0.33", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/AHPTubC0OvZGSy2tfjvge8i6PbKzwb94.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Peroni Nastro Azzurro 0.33", Description = "", Price = 220.00m, ImageUrl = "https://www.korpa.ba/product_uploads/DCOXMSxEs5vP2eqgVTaZ1BfHRma6sL9R.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Peroni Red 0.33", Description = "", Price = 170.00m, ImageUrl = "https://www.korpa.ba/product_uploads/8K7CfyfYzMSiqTFvxEub5agd79uXKIjz.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Asahi 0.33", Description = "", Price = 210.00m, ImageUrl = "https://www.korpa.ba/product_uploads/hLv3A8GH4xDS3iqNXeIOjPU1SbZQYuvt.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Bavaria 0.25", Description = "", Price = 180.00m, ImageUrl = "https://www.korpa.ba/product_uploads/SvxlvYVc5Ju9Ho23Plh9BGqODDdnnfOw.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Bavaria 0.33", Description = "", Price = 170.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xknrYk1ukUOvDo0cXecRGSe6YQXJMjR5.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Blue Moon 0.33", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/3VI8eJAVUHShq2niNhcq6iEF6ysNRCuc.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Chimay Belo 0.33", Description = "", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/NOzHGw20n8xR8iTqTzAjB4Rrcg3qOEon.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Chimay Plavo 0.33", Description = "", Price = 480.00m, ImageUrl = "https://www.korpa.ba/product_uploads/q89DuWzvDT1JYXEDjZH2R68cAL0XQn69.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Corona 0.33", Description = "", Price = 220.00m, ImageUrl = "https://www.korpa.ba/product_uploads/aFpX58TDCy10OocbhX9UeDgqJPWq7XUF.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Daura Damm (bez gluten) 0.33", Description = "", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/kupyxmB0GiROvYm25pPVcDX3snhwmCBd.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Daura Marzen Damm (bez gluten) 0.33", Description = "", Price = 280.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Z1EI9lCKKscCxbqpwDgOh3CSTEMzE3xG.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Esb 0.5", Description = "", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ZfvFpLcFx6e35L2H97DG6q3J83S4fTuD.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Grolsch 0.45", Description = "", Price = 270.00m, ImageUrl = "https://www.korpa.ba/product_uploads/lRcuvpyT7OuKXX1mAuKz3HxNDMeoMLre.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Gulden-Draak 0.33", Description = "", Price = 470.00m, ImageUrl = "https://www.korpa.ba/product_uploads/blCCd66ir2QWhwOcC8lQz7ynq3FYdMAP.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Kwak 0.33", Description = "", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/sfg8sMFWQtrVQqLWCbxFxdjuClotjMnX.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trap Blond 0.75", Description = "", Price = 840.00m, ImageUrl = "https://www.korpa.ba/product_uploads/iU8ebkaS4ZEubI38biKvlmvgqN3fEk0J.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trap Isidor 0.75", Description = "", Price = 900.00m, ImageUrl = "https://www.korpa.ba/product_uploads/eFkEjBadrvLHQrmi9CUG7xHgssMlE5fd.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trap Witte Trapist 0.33", Description = "", Price = 300.00m, ImageUrl = "https://www.korpa.ba/product_uploads/AL2apvbgupsbUrFzbFxrOHiz9QrIBaZV.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trap Witte Trapist 0.75", Description = "", Price = 790.00m, ImageUrl = "https://www.korpa.ba/product_uploads/qH4Eocjf7lb0Zv29VgqEMKcHi8Lu1OWB.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trape Blond 0.33", Description = "", Price = 330.00m, ImageUrl = "https://www.korpa.ba/product_uploads/l0IUrPCSYrMhaHIDDkyIvxwrj5PS7xSl.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trap Isidor 0.33", Description = "", Price = 340.00m, ImageUrl = "https://www.korpa.ba/product_uploads/toh1ynTJgG0AgExH38qQg1N5TmqYrEme.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trappe Quadrupel 0.33", Description = "", Price = 400.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xgWgeXcLmD7zjTt7V0oe3qwqz8H2HELt.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trap Witte Trapist 0.75", Description = "", Price = 790.00m, ImageUrl = "https://www.korpa.ba/product_uploads/RS5ZSCMLFsnPF3fEnq4vhrFu0afb697u.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "La Trap Witte Trapist 0.33", Description = "", Price = 340.00m, ImageUrl = "https://www.korpa.ba/product_uploads/5L461GF8K5mrgEsmUw7PHqcXpB0jsmtQ.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "London Pride 0.33", Description = "", Price = 290.00m, ImageUrl = "https://www.korpa.ba/product_uploads/l32nqYLopZHDQUl5ks2llaeVFETqVE4O.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Pilsner Urquell 0.33", Description = "", Price = 190.00m, ImageUrl = "https://www.korpa.ba/product_uploads/tC16ja2NRrUctySHCRRcuTBYoImVc3wZ.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Tripel Karmeliet 0.33", Description = "", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/9y8pClRbej9ZxXCv4xekHzHX2PhrcKOx.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Weichenstephaner Kellerbier 1516 0.5", Description = "", Price = 370.00m, ImageUrl = "https://www.korpa.ba/product_uploads/urE3yB6DXhvOn9FD2Fk9vheoBoPFsEsk.jpg", MenuId = beer.Id });
                restaurant.Menus.Add(beer);

                restaurant.Menus ??= new List<Menu>();
                restaurantList.Add(restaurant);
            }

            // === Enriko === (matches Java exactly)
            {
                var restaurant = new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Enriko",
                    Description = "Доставуваме до Вашата врата",
                    StreetAddress = "",
                    City = "Skopje",
                    ImageUrl = "https://korpa.ba/restaurant_uploads/wxj8DkfJAMPwyEC8YvIxDjA3n6csuZ7E.JPG",
                    Category = "Italian / Pizza",
                    DeliveryPrice = 25
                };

                // Section: Сендвичи 🥪🌮
                var sandwiches = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Сендвичи 🥪🌮",
                    RestaurantId = restaurant.Id
                };
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Енрико сендвич", Description = "Лепиња со сусам, сос од домати, кашкавал, свинска шунка, печурки, мајонез, павлака, оригано (Алергени - глутен, јајца, суcам, млеко)", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/MlERfkHw0uaTvOnFXAGK6zTs8gJCV9td.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Домашен сендвич", Description = "Лепиња со сусам, кашкавал, печеница, печурки, мајонез, домати, корнишони, оригано (Алергени - Глутен, сусам, млеко, јајца)", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/VdAsoNAB7CfgekBoQffWPeZxmcL0mkQF.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Туна сендвич", Description = "Лепиња со сусам, кашкавал, туна, домати, кромид, зелена салата, мајонез (Алергени - јајца,глутен,сусам,млеко,риби)", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Sf5Dohg0Q6gWW39IhlRWa0ic3c4Q91MK.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кулен сендвич", Description = "Лепиња со сусам, кашкавал, кулен, печурки, домати, зелена салата, мајонез, павлака (Алергени - јајца,глутен,млеко,сусам)", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/HLTnXU069wYN0ZdCyJoo7zfLBdomWobJ.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Телешкa - Свинскa пршутa сендвич", Description = "Лепиња со сусам, кашкавал, марула,домати, телешкa-свинскa пршутa, мајонез (Алергени - јајца,млеко,глутен,сусам)", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/kTudGEv5zILbjZAMqm2zMkDIwwH77maz.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Вегетаријански сендвич", Description = "Лепиња со сусам, марула, домати, моцарела, горгонзола, свежи печурки, мајoнез (Алергени - јајца,глутен,млеко,сусам)", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/P3sv2xWEaE8xWPM7xTreafaQAGgLqI2m.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Рукола сендвич", Description = "Лепиња со сусам, домати, моцарела,рукола, пршута, босилок, маслинки (Алергени - јајца,млеко,глутен,сусам)", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/6UiceqdKEjX3J70TuDyaGxRsmkSoyQqx.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки сендвич", Description = "Лепиња, пилешки стек, ајдамер, кромид, сенф, шери домати, марула, корнишони, мајонез (Алeргени - јајца,млеко,сусам,сенф,глутен)", Price = 300.00m, ImageUrl = "https://www.korpa.ba/product_uploads/FKhFLhCoTciNY6Ipz3CIRcVYE2p9mVNW.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки сендвич со пaрмезан", Description = "Лепиња, пилешки стек, пармезан, шери домати, рукола, сенф, мајонез (Алергени - јајца,млеко,глутен,сусам,сенф)", Price = 300.00m, ImageUrl = "https://www.korpa.ba/product_uploads/QmKfXdXgo8y86qlnG4OfpkPe1w7NMe5K.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Италијански сендвич", Description = "Лепиња, мортадела, пармезан, шери домати, рукола, мајонез, јајце (Алергени - јајца, сусам,млеко,глутен)", Price = 300.00m, ImageUrl = "https://www.korpa.ba/product_uploads/eC0UymhTsVbolZDA0CNDvJoARoACfCr0.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки сендвич со сланина", Description = "Лепиња, пилешки стек, ајдамер, корнишони, кромид, сенф, шери домати, марула, пржена сланина (Алергени - јајца, млеко, сенф, сусам, глутен)", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/KTJYL8XUk7CoikuuEKNkNXs9h5Dnpu3g.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки сендвич со авокадо", Description = "Лепиња, крем од авокадо (авокадо, кравјо сирење, лук), пилешки стек, пржена сланина, шери домати (Алeргени - јајца,глутен,млеко,сусам)", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/jr05T69GT0aHeuzIHjEDa5szIcRO5nFk.jpg", MenuId = sandwiches.Id });
                sandwiches.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки песто сендвич", Description = "Лепиња, пилешки стек, моцарела, песто сос, шери домати, кромид (Алeргени - јајца,млеко,сусам,глутен,јаткасти)", Price = 310.00m, ImageUrl = "https://www.korpa.ba/product_uploads/qn1rUnIRPrRCvJPGQspAJ79eECRJU9KQ.jpg", MenuId = sandwiches.Id });
                restaurant.Menus.Add(sandwiches);

                // Section: Салати 🥗🥬
                var salads = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Салати 🥗🥬",
                    RestaurantId = restaurant.Id
                };
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Шопска салата", Description = "Домати, краставица, кромид, сирење, маслинка  (Алeргени - Млеко)", Price = 320.00m, ImageUrl = "https://www.korpa.ba/product_uploads/YoT24mjlnp7jrKiyk0RcfIgPjcZHCg9f.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Грчка салата", Description = "Домати, краставица, кромид, сирење, маслинки, оригано (Алергени - млеко)", Price = 340.00m, ImageUrl = "https://www.korpa.ba/product_uploads/sGCeJ56OGhmEohyP9MqSzwV4DZwzoh5r.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Мешана салата", Description = "Зелка, марула, ајсберг, краставица, морков, пченка, ротква, маслинка, цвекло", Price = 280.00m, ImageUrl = "https://www.korpa.ba/product_uploads/d83rxaVk4MCpg5vXUHtnMQchePGYu8hN.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Туна салата", Description = "Марула, ајсберг, краставица, лимон, кромид, туна, ротква, маслинка (Алергени - риби)", Price = 380.00m, ImageUrl = "https://www.korpa.ba/product_uploads/fPdaayNb324PHKVqBiVbgK484fP6C8qg.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Енрико салата", Description = "Рукола, марула, ајсберг, маслинки, шери домати, пармезан, пршута", Price = 400.00m, ImageUrl = "https://www.korpa.ba/product_uploads/F2KvWZ4f1MHTpU8nZdFAzrRF2vLMsI4t.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Рукола - Шери домат салата", Description = "Рукола, шери, домат, пармезан  (Алергени - млеко)", Price = 320.00m, ImageUrl = "https://www.korpa.ba/product_uploads/8Q5BApDY8QOSrssZKyMd3JvqqwgZaw5p.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Тробојна салата", Description = "Домати, моцарела, авокадо, босилок  (Алергени- млеко)", Price = 380.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ZEzxGlzotULlRosHaRkHs1YEaqtG2OaK.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Капрезе салата", Description = "Домати, босилок, моцарела, маслиново масло", Price = 380.00m, ImageUrl = "https://www.korpa.ba/product_uploads/DncCu4snpLp4gV9CLFfewXz2tlC9B2UT.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Цезар салата", Description = "Марула, ајсберг, пилешки стек, печени лепчиња, пармезан, јајцe (Алергени - глутен, јајца, млеко)", Price = 420.00m, ImageUrl = "https://www.korpa.ba/product_uploads/yK1RmaTKiVOyUsQOFL8z1mkVm5ZnQRtq.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Ница салата", Description = "Туна, рукола, ајсберг, кромид, јајце, шери домати, маслинки, лимон (Алергени - јајца, риба)", Price = 400.00m, ImageUrl = "https://www.korpa.ba/product_uploads/JwwTPpywv6D3Xo0ujKs5jhnKLWNmBqrD.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Шкампи салата", Description = "Шкампи, авокадо, рукола, ајсберг, шери домати, лимон  (Алeргени - черупници)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/LeZ2sCzdNIRWXs5CQymyBZ8LGAcfF92F.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Горгонзола Ореви салата", Description = "Ајсберг, рукола, плаво сирење, јаболко, ореви, шери домати (Алергени - јаткасти, млеко)", Price = 400.00m, ImageUrl = "https://www.korpa.ba/product_uploads/2GM2aydCVpOkMxiwFPYt7ZVl4WBaXAt2.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Брокула салата", Description = "Брокула, шери домат, млад кромид, пармезан, борово семе, маслинки  (Алергени - млеко, јаткасти)", Price = 360.00m, ImageUrl = "https://www.korpa.ba/product_uploads/pQnfCZg8dtDV0v6SiEOKSnUTctUd1Ibb.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Спанаќ - јагоди салата", Description = "Млад спанаќ, јагоди, кравјо сирење, карамелизиран ореви, дресинг (Алергени - млеко, јаткасти)", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/80PB9u4gseFWPOhdoEWX03ExUBY9idqJ.jpg", MenuId = salads.Id });
                salads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Спанаќ - Сланина салата", Description = "Млад спанаќ, авокадо, дресинг,сушен домат, црвен кромид, сланина пржена", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/5HcUL1a08RjDMhpLQ9X537ja6unFynN9.jpg", MenuId = salads.Id });
                restaurant.Menus.Add(salads);

                // Section: Ордевери 🧀🥓
                var hors = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Ордевери 🧀🥓",
                    RestaurantId = restaurant.Id
                };
                hors.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Шампињони на путер", Description = "(Алергени - млеко)", Price = 320.00m, ImageUrl = "https://www.korpa.ba/product_uploads/DOnpmB4PIfjz8yooFsnyk6923Enp4RXJ.jpg", MenuId = hors.Id });
                hors.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Похован кашкавал", Description = "(Алeргени - глутен, млеко, јајца)", Price = 300.00m, ImageUrl = "https://www.korpa.ba/product_uploads/JYCWT1JOzM0NcKAGA7l4AYo75aIjB2uk.jpg", MenuId = hors.Id });
                restaurant.Menus.Add(hors);

                // Section: Паста Салати 🥗🍝
                var pastaSalads = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Паста Салати 🥗🍝",
                    RestaurantId = restaurant.Id
                };
                pastaSalads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Италијанска Паста салата", Description = "Фусили, шери домат, авокадо, моцарела, босилок, маслиново масло (Алергени- јаткасти,млеко)", Price = 380.00m, ImageUrl = "https://www.korpa.ba/product_uploads/pw6Ltyv5872O5bNng0y3r2fES9cxxbnL.jpg", MenuId = pastaSalads.Id });
                pastaSalads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Туна Паста салата", Description = "Фусили, шери домат, млад кромид, маслинки, туна, магдонос, јајце (Алeргени, јајца, риби)", Price = 380.00m, ImageUrl = "https://www.korpa.ba/product_uploads/nHrZKTf9MrZFFbBLzJOFeRAI0zpRx0Al.jpg", MenuId = pastaSalads.Id });
                pastaSalads.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Брокула Пилешка Паста салата", Description = "Фусили, шери домат, брокула, млад кромид, пилешки стек, пармезан  (Алергени - млеко)", Price = 380.00m, ImageUrl = "https://www.korpa.ba/product_uploads/mCazleeoWmZPLycvg9hr1xSozWPnEcjb.jpg", MenuId = pastaSalads.Id });
                restaurant.Menus.Add(pastaSalads);

                // Section: Омлети 🥘🥚🧈
                var omelettes = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Омлети 🥘🥚🧈",
                    RestaurantId = restaurant.Id
                };
                omelettes.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Омлет Енрико", Description = "Јајца, кашкавал, шунка, печурки, павлака, маслинки, феферони, оригано, фурнарина (Алергени - јајца, млеко)", Price = 300.00m, ImageUrl = "https://www.korpa.ba/product_uploads/c7XnwHYNrdb81IEcJSw0fcHH5IE392hf.jpg", MenuId = omelettes.Id });
                restaurant.Menus.Add(omelettes);

                // Section: Пици 🍕
                var pizzas = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Пици 🍕",
                    RestaurantId = restaurant.Id
                };
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Маргарита пица", Description = "Сос од домати, кашкавал, оригано, маслинка (Алергени - глутен, млеко, јајца)", Price = 380.00m, ImageUrl = "https://www.korpa.ba/product_uploads/KeVHRjyfnGMd3uwn9vhUiBTuagMX7yJn.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Вегетаријана пица", Description = "Сос од домати, кашкавал, печурки, оригано (Алергени - глутен, млеко, јајца)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/YUzYal9sUf2h7duf4PV3llW1mgxgi6Mv.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Наполитана пица", Description = "Сос од домати, кашкавал, шунка, оригано (Алергени - глутен, јајца, млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/6Q1asUJ7JaXqY6xy9lRZJydShIY1VJdt.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Капричиоза пица", Description = "Сос од домати, кашкавал, шунка, печурки, оригано (Алергени - глутен, јајца, млеко)", Price = 470.00m, ImageUrl = "https://www.korpa.ba/product_uploads/AqgYZj8u6H4fKhQ1pI4ePkFqP6QszHjT.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Преклопена пица", Description = "Сос од домати, кашкавал, шунка, печурки, сусам, оригано (Алергени - глутен, јајца, млеко,)", Price = 470.00m, ImageUrl = "https://www.korpa.ba/product_uploads/njLOskbIQJJnwpvyeVzJQ7zBJvcoONaU.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Везувио пица", Description = "Сос од домати, кашкавал, шунка, печурки, јајце, оригано (Алергени - глутен, јајца, млеко)", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/HtbS91pMHDLU73DRwUhinnKAT3uxRs8R.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Стелато пица", Description = "Сос од домати, кашкавал, шунка, печурки, павлака, оригано (Алргени - глутен, јајца, млеко)", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/9NQGYerVAMayXZPdV1gHDrilpC1EdfHE.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Мајонеза пица", Description = "Сос од домати, кашкавал, шунка, печурки, мајонез, оригано (Алергени - глутен, јајца, млеко)", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/1ITfsqCfFyzJfFxNvWaMBHY4ZtBH0s7T.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кватро стаџоне пица", Description = "Сос од домати, кашкавал, шунка, сланина, колбас, оригано, павлака, печурки, феферони, маслинка (Алергени - глутен, јајца, млеко)", Price = 500.00m, ImageUrl = "https://www.korpa.ba/product_uploads/9DpYQbRnwWRaX4GzASFbhnS81kX86W8x.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Морски свет пица", Description = "Сос од домати, кашкавал, туна, школки, ракчиња, октопод, маслинки, лук, оригано (Алергени - глутен, млеко, јајца, мекотелци, черупници)", Price = 560.00m, ImageUrl = "https://www.korpa.ba/product_uploads/w0okQ30tpQKMlCoqNIi5EajRMTqzhEr0.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Зелена пица", Description = "Сос од домати, кашкавал, домати,пиперки, кромид, маслинки, оригано (Алергени - глутен, млеко, јајца)", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/LLHD2lji1zIrw79qNY9UPhdxzQyiUOX1.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Капричиоза со зеленчук", Description = "Сос од домати, кашкавал, шунка, печурки,домати, пиперки, кромид, маслинки (Алергени - глутен, млеко, јајца)", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/RDHopyiksgfZKdHT1LjRkm6faxcnFPBW.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Наполитана со зеленчук", Description = "Сос од домати, кашкавал, домати,пиперки, кромид, маслинки (Алергени - глутен, јајца, млеко)", Price = 470.00m, ImageUrl = "https://www.korpa.ba/product_uploads/DQNZcpZvZIngCmtK2dUbtSkjiB4dyR0v.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Вегетаријана со зеленчук", Description = "Сос од домати, кашкавал, печурки, домати, пиперки, кромид, маслинки, оригано (Алергени - Глутен, јајца, млеко)", Price = 470.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ytgRPgjKAcSD0twkTpHlJ5qyPQL2J4V0.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кватро салами пица", Description = "Сос од домати, кашкавал, сланина, свински пршут, кулен, суџук, маслинка, феферони, павлака, оригано (Алергени - глутен, јајца, млеко)", Price = 520.00m, ImageUrl = "https://www.korpa.ba/product_uploads/lCt0Z0IEUNFKz5iyeZKj5AnNv3LLqXuB.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Помодорина пица", Description = "Сос од домати, кашкавал, шери домати, босилок, лук, маслинки (Алергени - глутен, млеко, јајца)", Price = 440.00m, ImageUrl = "https://www.korpa.ba/product_uploads/hkwvJxbGnlkTeOLNnQg37cOYfguKgmcv.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Енрико пица", Description = "Сос од домати, кашкавал, шунка, печурки,сланина, јајце, феферони, маслинки, оригано(Алергени - глутен, јајца,млеко)", Price = 500.00m, ImageUrl = "https://www.korpa.ba/product_uploads/AknyCsvx9hpqPfCCrLNhTYaBMIx1fEnr.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Свински-Телешки пршут пица", Description = "Сос од домати, кашкавал, пршут, оригано (Алергени - глутен, јајца, млеко)", Price = 500.00m, ImageUrl = "https://www.korpa.ba/product_uploads/1QKuKot3KUT7n8dXnIrJF3JmDy3NyiMS.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кулен пица", Description = "Сос од домати, кашкавал, кулен, маслинки, оригано (Алергени - глутен, јајца, млеко)", Price = 500.00m, ImageUrl = "https://www.korpa.ba/product_uploads/qItsDEDBtpNCRKzWgx2mjocJid9VqlC3.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Ориентална пица", Description = "Сос од домати, кашкавал, суџук, јајце, маслинки, оригано (Алергени - глутен, јајца, млеко)", Price = 470.00m, ImageUrl = "https://www.korpa.ba/product_uploads/0OfioKmWjqGQpCKxng9bjuVTn1gXKF2N.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Диавло пица", Description = "Сос од домати, кашкавал, кулен, пиперка, кромид, феферони, маслинки (Алергени - глутен, млеко , јајца)", Price = 500.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xJ2CCLGBcey0vatZQw1ta6HYLPVZ1zlq.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Шкампи пица", Description = "Соc со домати, моцарела, шкампи, рукола, маслинки, пармезан, лук (Алергени - глутен, јајца, млеко, черупници)", Price = 520.00m, ImageUrl = "https://www.korpa.ba/product_uploads/PKCIitqSXxxgUHoAOo0kDFyunRjw525Z.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кватро формаџи пица", Description = "Сос од домати, ајдамер, горгонзола,моцарела, пармезан, оригано (Алeргени - глутен, млеко, јајца)", Price = 500.00m, ImageUrl = "https://www.korpa.ba/product_uploads/vMvHQ3PDzlH5uU6o6tH2WxXAPNHqrcam.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пармиџана пица", Description = "Сос од домати, кашкавал, лук, пармезан, модар патлиџан, оригано (Алергени - глутен, јајца, млеко)", Price = 440.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ep9UoGK3d9nH3I2b7R2OOAccCljH1Eq8.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Вргањ пица", Description = "Сос од домати, кашкавал, вргањ, оригано, лук, магдонос (Алергени - глутен, јајца, млеко)", Price = 510.00m, ImageUrl = "https://www.korpa.ba/product_uploads/G8YE1rrVKVYmUEPZ0S12pgXxae2OLdjV.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Рукола пица", Description = "Сос од домати, моцарела, рукола, пршут, босилок, маслинки (Алергени - глутен, млеко, јајца)", Price = 510.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Zb6WxbVl7smRtkRnbpamserngIRPpJMF.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Карбонара пица", Description = "Сос од домати, кашкавал, сланина, јајце, пармезан, оригано (Алергени - глутен, јајца,млеко)", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/6cbouq40KryNidF2NPlm8cvX7mxZRPdz.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кари пица", Description = "Сос од домати, кашкавал, пилешки стек, кромид, кари (Алергени - глутен, јајца, млеко)", Price = 480.00m, ImageUrl = "https://www.korpa.ba/product_uploads/55CZoqSEhVaJjZtcVXuixwP1jw11bI1x.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пица Брокула", Description = "Сос од домати, кашкавал, брокула, шери домат, лук, пармезан, борово семе (Алергени - глутен, млеко, јајца)", Price = 440.00m, ImageUrl = "https://www.korpa.ba/product_uploads/mcR0PrgJS0zMEbav58pthVrcuOK7Ptau.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кордон блу пица", Description = "Сос од домати, кашкавал, шунка, пилешки стек, презла, пармезан (Алергени - глутен ,млеко, јајца)", Price = 490.00m, ImageUrl = "https://www.korpa.ba/product_uploads/d3tNcbdsJdLALJvTqkSV26Vl5jTZkCOz.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Хаваи пица", Description = "Сос од домати, кашкавал, оригано, шунка, ананас (Алергени - глутен, млеко, јајца)", Price = 480.00m, ImageUrl = "https://www.korpa.ba/product_uploads/MyZKXVCyj8tBPFV65W4BprQnVWDQrFGR.jpg", MenuId = pizzas.Id });
                pizzas.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Тиквици пица", Description = "Сос од домати, тиквици, шери домати, лук, кашкавал, кравјо сирење, босилок (Алергени - глутен, јајца,млеко)", Price = 450.00m, ImageUrl = "https://www.korpa.ba/product_uploads/dCTOPTYBWtliX8azxqbadQeISc15L2h6.jpg", MenuId = pizzas.Id });
                restaurant.Menus.Add(pizzas);

                // Section: Панцероти 🧀👨‍🍳
                var panzerotti = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Панцероти 🧀👨‍🍳",
                    RestaurantId = restaurant.Id
                };
                panzerotti.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Панцерота Кордон блу", Description = "Доматен сос, кашкавал, шунка, пилешки стек (Алергени - глутен,јајца,млеко)", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/o4663OAhyzMXSONMIET6IPUOzGLo5UMS.jpg", MenuId = panzerotti.Id });
                panzerotti.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Панцерота", Description = "", Price = 190.00m, ImageUrl = "https://www.korpa.ba/product_uploads/X55OR8fr007cXlIqvxntZDmclu9fK3CW.jpg", MenuId = panzerotti.Id });
                restaurant.Menus.Add(panzerotti);

                // Section: Пастрмајлии 👩‍🍳
                var pastrmajlija = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Пастрмајлии 👩‍🍳",
                    RestaurantId = restaurant.Id
                };
                pastrmajlija.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пастрмајлија - Свинско месо и зачини", Description = "(Алергени - глутен)", Price = 360.00m, ImageUrl = "https://www.korpa.ba/product_uploads/mKMU9h53KBropgi1tZKq3csbeTXX2U4O.jpg", MenuId = pastrmajlija.Id });
                pastrmajlija.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пастрмајлија - Свинско месо, зачини и јајце", Description = "(Алергени - Глутен, јајца)", Price = 390.00m, ImageUrl = "https://www.korpa.ba/product_uploads/PSOJTzqT3t9lZ7dPcgccePYVMGqPOUEh.jpg", MenuId = pastrmajlija.Id });
                pastrmajlija.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пастрмајлија - Свинско месо, зачини и сирење", Description = "(Алергени - Глутен, млеко)", Price = 400.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ftVHxsJSgD8aJ5OBuzkPhgrauCflU6jc.jpg", MenuId = pastrmajlija.Id });
                pastrmajlija.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пастрмајлија - Свинско месо, зачини, јајце и сирење", Description = "(Алергени - Глутен, jajца, млеко)", Price = 420.00m, ImageUrl = "https://www.korpa.ba/product_uploads/L9DyYYVmiLYj0JCi8L6XNogtjXnyZVer.jpg", MenuId = pastrmajlija.Id });
                restaurant.Menus.Add(pastrmajlija);

                // Section: Фурнарини 🥖
                var furnarini = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Фурнарини 🥖",
                    RestaurantId = restaurant.Id
                };
                furnarini.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фурнарини со сусам", Description = "(Алергени - Глутен)", Price = 140.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ZYa4I5F5qOOAZU0cNg6uzQhEPeGhFjhl.jpg", MenuId = furnarini.Id });
                furnarini.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фурнарини со лук", Description = "(Алергени - Глутен)", Price = 140.00m, ImageUrl = "https://www.korpa.ba/product_uploads/cGv1sFs5kriDVVD3XY2V9qZKwzCVsagx.jpg", MenuId = furnarini.Id });
                furnarini.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фурнарини со маслинки", Description = "(Алергени - Глутен)", Price = 160.00m, ImageUrl = "https://www.korpa.ba/product_uploads/paSE9tdZ5JbtlT015W6DqtTlP5Wqrq2M.jpg", MenuId = furnarini.Id });
                furnarini.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фурнарини со кашкавал", Description = "(Алергени - Глутен)", Price = 160.00m, ImageUrl = "https://www.korpa.ba/product_uploads/kkFrbcXpTVqY6fJSaeV38QVPxOsNLSZs.jpg", MenuId = furnarini.Id });
                restaurant.Menus.Add(furnarini);

                // Section: Паста 🍝
                var pasta = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Паста 🍝",
                    RestaurantId = restaurant.Id
                };
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Болоњезе сос - сува паста", Description = "Сос од домати, телешко мелено месо, зачини (Алергени - сулфур диоксид, целер)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/B3eEhFnErTKHl054jgzmqj2CUrLBgLrO.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фунги сос - сува паста", Description = "Слатка павлака, шунка, печурки, путер, зачини, кашкавал (Алергени - млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/esQSTVIcmV5hq1kBVkWmwBJBRMFNSoH3.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Фунги сос - свежа паста", Description = "Слатка павлака, шунка, печурки,путер, зачини, кашкавал (Алергени - млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/T6XbdM6I5MsDJCXtHNGka9ys4ju61luA.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Аматричијано сос - сува паста", Description = "Слатка павлака, сос од домати, печеница, путер, кромид, чили (Алергени- млеко)", Price = 410.00m, ImageUrl = "https://www.korpa.ba/product_uploads/fv53Otzoo0Vism5n593R0S8hxIYNp1Hg.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Аматричијано сос - свежа паста", Description = "Слатка павлака, сос оддомати, печеница, путер, кромид, чили (Алергени млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/uJ55bPBfNGQz5teThZIf8GRiMZw6eGZp.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Песто сос - сува паста", Description = "Mагдонос, босилок, лук, борово семе, пармезан, маслиново масло (Алергени - јаткасти, млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/cEZ1vXq3KgyZL6h1vW8X866KhV9JdL9n.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Песто сос - свежа паста", Description = "Магдонос, босилок, лук, борово семе,пармезан, маслиново масло (Алергени - јаткасти, млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/nCjfG7BWnjNmL2kCOj09TR8Btek4IR43.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Базилико - сува паста", Description = "Cос од домати, босилок, лук, пармезан, маслиново масло (Алергени - млеко)", Price = 410.00m, ImageUrl = "https://www.korpa.ba/product_uploads/O5KTai1YoVllyUlzoAmslULc4s3P65mJ.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Базилико - свежа паста", Description = "Сос од домати, босилок, лук, пармезан, маслиново масло(Алергени - млеко)", Price = 440.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ndAgBW0jvEAcOK2syhFySVEAZ7c7kYqw.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Арабијата - сува паста", Description = "Чили, лук, домати, босилок, маслиново масло", Price = 410.00m, ImageUrl = "https://www.korpa.ba/product_uploads/OgVWwJPImyE7xB57GpZqG2lybm8T1HlK.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Арабијата - свежа паста", Description = "Чили, лук, домати, босилок, маслиново масло", Price = 440.00m, ImageUrl = "https://www.korpa.ba/product_uploads/w6Xvdjqol9rMGYHgI44gRSsF6Do9MR6o.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Морски свет - сува паста", Description = "Слатка павлака, ракчиња, школки, октопод, магдонос, зачини, белo вино (Алергени - млеко, риби, черупници, целер)", Price = 520.00m, ImageUrl = "https://www.korpa.ba/product_uploads/uCvfn9MJFzFqkVnSxlOkIceFmBXKm8kN.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Морски свет - свежа паста", Description = "Слатка павлака, ракчиња, школки, октопод, магдонос, зачини, белo вино (Алергени - млеко, риби, черупници, целер)", Price = 540.00m, ImageUrl = "https://www.korpa.ba/product_uploads/X89Cjf6llWSyVOScUIsvXqF1WsnOAqsv.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Сос со вргањ - сува паста", Description = "Слатка павлака, вргањ, лук, пармезан, магдонос (Алергени - млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/1MVbO4uOBiQzRmYc6daQlAUxULw6HhqI.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Сос со вргањ - свежа паста", Description = "Слатка павлака, вргањ, лук, пармезан, магдонос (Алергени - млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Amy16yz1zb77lpL1HQGepknqjWd2LyLN.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки сос со зелен лимон - сува паста", Description = "Слатка павлака, пилешко, зелен лимон, лук, пармезан (Алергени - млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/1sld3yt2ySQlkGIWtxBzhjbbOCMlGETo.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки сос со зелен лимон - свежа паста", Description = "Слатка павлака, пилешко, зелен лимон, лук, пармезан (Алергени - млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/efBqbm2N16N03R9iySYJzWpbLzI4QlZH.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки сос со кари - сува паста", Description = "Слатка павлака, пилешко, свежи печурки, кари, пармезан (Алергени - млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/a09Gjx0JCkPywoMHRsfUq0lqpBZmWc16.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешки сос со кари - свежа паста", Description = "Слатка павлака, пилешко, свежи печурки, кари, пармезан (Алергени - млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/M5WE1yFwwHr3d8IxPTgTPae8GKlN9yEf.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пршут - сува паста", Description = "Слатка павлака, путер, пршут, зачини, пармезан (Алергени - млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/8SZEK8StyXWxFvOqdxHSzjpqtYMpHTaf.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пршут - свежа паста", Description = "Слатка павлака, путер,пршут, зачини, пармезан (Алергени - млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/zNq9wdTPArANu7wUBar8wliNC1GWWxTV.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешко со спанаќ - сува паста", Description = "Слатка павлака, пилешко, песто, кромид, шери домати, спанаќ, маслиново масло (Алергени - млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/EB13nUy6VJyPnsLG38LHGozMFEAaCnAR.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Пилешко со спанаќ - свежа паста", Description = "Слатка павлака, пилешко, песто, кромид, шери домати, спанаќ, маслиново масло (Алергени - млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/fGvoSBzpH1kZYMSF3KfoOyuxPvYIBbNU.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Горгонзола - Ореви - свежа паста", Description = "Слатка павлака, плаво сирење,ореви, пармезан (Алергени - черупници, млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/R0Wky1WqBtNNJnuLRoGK6aovqRI62kYN.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Горгонзола - Ореви - сува паста", Description = "Слатка павлака, плаво сирење,ореви, пармезан (Алергени - черупници, млеко)", Price = 430.00m, ImageUrl = "https://www.korpa.ba/product_uploads/MhwaMGgIIuXtERXlBU1gbpj8Sp2hLLJB.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Лазањи со свежо тесто", Description = "Бoлоњезе сос, бешамел, пармезан, кашкавал (Алергени - целер, сулфур диоксид, млеко)", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/PWLFvVncalspHWepv8GFhN7NbCd8FyWn.jpg", MenuId = pasta.Id });
                pasta.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Болоњезе сос - свежа паста", Description = "", Price = 460.00m, ImageUrl = "https://www.korpa.ba/product_uploads/py8iKbzh4NvP19FOv5hgz1DEKekvZ5dh.jpg", MenuId = pasta.Id });
                restaurant.Menus.Add(pasta);

                // Section: Десерти 🍰🍮
                var desserts = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Десерти 🍰🍮",
                    RestaurantId = restaurant.Id
                };
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Тирамису", Description = "(Алергени - глутен, јајца, млеко, јакасти)", Price = 220.00m, ImageUrl = "https://www.korpa.ba/product_uploads/hxBbGra66qEunkK783af5iNa9SI8DH1g.jpg", MenuId = desserts.Id });
                desserts.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Топло ладно", Description = "(Алергени - Jajца, млеко)", Price = 260.00m, ImageUrl = "https://www.korpa.ba/product_uploads/IL87i2s0MQO5qi7hP93INEcyrHDkz7vH.jpg", MenuId = desserts.Id });
                restaurant.Menus.Add(desserts);

                // Section: Палачинки 🥞
                var pancakes = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Палачинки 🥞",
                    RestaurantId = restaurant.Id
                };
                pancakes.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Палачинки", Description = "2 палачинки со додаток по избор", Price = 240.00m, ImageUrl = "https://www.korpa.ba/product_uploads/jSPYQY85pq3ioVeg3U9Ucrspijvy4ici.jpg", MenuId = pancakes.Id });
                restaurant.Menus.Add(pancakes);

                restaurant.Menus ??= new List<Menu>();
                restaurantList.Add(restaurant);
            }

            // === Royal Burger Debar Maalo === (matches Java exactly)
            {
                var restaurant = new Restaurant
                {
                    Id = Guid.NewGuid(),
                    Name = "Royal Burger Debar Maalo",
                    Description = "Доставуваме до Вашата врата",
                    StreetAddress = "",
                    City = "Skopje",
                    ImageUrl = "https://korpa.ba/restaurant_uploads/Gay0IEPWugE4a5KHek6gMw28AUEY2SLC.jpg",
                    Category = "Burgers",
                    DeliveryPrice = 25
                };

                // Section: ROYAL COMBO 👑
                var royalCombo = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "ROYAL COMBO 👑",
                    RestaurantId = restaurant.Id
                };
                royalCombo.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Combo 1", Description = "3 x Chicken Tenders (пилешки прсти), 1 x French Fries, 1 x Ranch sauce", Price = 165.00m, ImageUrl = "https://www.korpa.ba/product_uploads/3lD3PSZm7cM3CiRpZj7txrQDljcOTr3R.jpg", MenuId = royalCombo.Id });
                royalCombo.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Combo 2", Description = "5 x Chicken Tenders (пилешки прсти), 1 x French Fries, 1 x Ranch sauce", Price = 200.00m, ImageUrl = "https://www.korpa.ba/product_uploads/IoIQ0hArzKeZdAGMPGcA4TsMit48025B.jpg", MenuId = royalCombo.Id });
                royalCombo.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Combo 3", Description = "4 x Nuggets, 4 x Chili Cheese Nuggets, Ranch Sauce", Price = 140.00m, ImageUrl = "https://www.korpa.ba/product_uploads/5ynAwx2iIevMSA4GjGsowAgxcfrcBiZE.jpg", MenuId = royalCombo.Id });
                royalCombo.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Combo 4", Description = "2 x Chicken Tenders (пилешки прсти), 4 x Chicken Nuggets, 6 x Onion Rings, 1 x Ranch sauce", Price = 180.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ZRdG29KRaOi1PhGK891Hy8YH3JGcPxRU.jpg", MenuId = royalCombo.Id });
                restaurant.Menus.Add(royalCombo);

                // Section: Burger 🍔
                var burger = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Burger 🍔",
                    RestaurantId = restaurant.Id
                };
                burger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Hamburger", Description = "Лепче, кромид, домат, кари сос, кисели краставички, плескавица, розев сос, марула", Price = 170.00m, ImageUrl = "https://www.korpa.ba/product_uploads/jJeUKOPaEI9B7zgWU2oH9fD0EJ7W80KN.jpg", MenuId = burger.Id });
                burger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Cheeseburger", Description = "Лепче, кромид, домат, кари сос, кисели краставички, две парчиња кашкавал, плескавица, розев сос, марула", Price = 190.00m, ImageUrl = "https://www.korpa.ba/product_uploads/LFPbiIHmGN5xvISH2rIYzh6DsZ7JPuwG.jpg", MenuId = burger.Id });
                burger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Baconburger", Description = "Лепче, кромид, домат, две парчиња сланина, кари сос, кисели краставички, кашкавал, плескавица, розев сос, марула", Price = 200.00m, ImageUrl = "https://www.korpa.ba/product_uploads/fBWylBpIi3fpyC5Ia79ZkxM4EJxzalM4.jpg", MenuId = burger.Id });
                burger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Doubleburger", Description = "Лепче, кромид, домат, кари сос, кисели краставички, четири парчиња кашкавал, две плескавици, розев сос, марула", Price = 230.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Rhq69iz3KYVOWEZu5F6MFrlCto5cYkJy.jpg", MenuId = burger.Id });
                burger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Royalburger", Description = "Лепче, кромид, домат, сланина, кари сос, кисели краставички, кајмак, плескавица, розев сос, марула", Price = 230.00m, ImageUrl = "https://www.korpa.ba/product_uploads/fGsgepnJNNzFjlsOsTFV2bCCNX5pfyJS.jpg", MenuId = burger.Id });
                burger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Vege Burger", Description = "Лепче, кромид, домат, кари сос, кисели краставички, кашкавал x 3, розев сос, марула", Price = 120.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Xia3u2tiATZyiQIKXnETmMTwGTTJd3Mb.jpg", MenuId = burger.Id });
                restaurant.Menus.Add(burger);

                // Section: Chicken Burger 🍗🍔
                var chickenBurger = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Chicken Burger 🍗🍔",
                    RestaurantId = restaurant.Id
                };
                chickenBurger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Crispy Chicken", Description = "Лепче, кромид, домат, кари сос, кисели краставички, две парчиња похован стек, розев сос, марула", Price = 180.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ZSiyHLVITpZf7atFPdhHDf2CvHESylqR.jpg", MenuId = chickenBurger.Id });
                chickenBurger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Cheese Chicken", Description = "Лепче, кромид, домат, кари сос, кисели краставички, две парчиња кашкавал, две парчиња похован стек, розев сос, марула", Price = 190.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Muoo7vncO83FmUdDHPnbLaJUSDipiYWj.jpg", MenuId = chickenBurger.Id });
                chickenBurger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Bacon Chicken", Description = "Лепче, кромид, домат, две парчиња сланина, кари сос, кисели краставички, кашкавал, две парчиња похован стек, розев сос, марула", Price = 200.00m, ImageUrl = "https://www.korpa.ba/product_uploads/HtnIKDsKTgtiWepEV8OkNye9TdeuNdnW.jpg", MenuId = chickenBurger.Id });
                chickenBurger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Spicy Chicken", Description = "Лепче, марула, розев сос, две парчиња поховано пилешко, кисели краставички, кари сос, чили зачин, домат, кромид", Price = 185.00m, ImageUrl = "https://www.korpa.ba/product_uploads/gEIDNisaMuZMbrScIo72pSpKXiwQGZ1A.jpg", MenuId = chickenBurger.Id });
                chickenBurger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Royal Chicken", Description = "Лепче, кромид, домат, две парчиња сланина, кари сос, кисели краставички, кајмак, две парчиња похован стек, розев сос, марула", Price = 230.00m, ImageUrl = "https://www.korpa.ba/product_uploads/4TozrDOGJWNsnTTaGIXLjNTOHdyqkOEu.jpg", MenuId = chickenBurger.Id });
                chickenBurger.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Chicken Burger", Description = "Лепче, кромид, домат, кари сос, кисели краставички, две парчиња стек на скара, розев сос, марула", Price = 185.00m, ImageUrl = "https://www.korpa.ba/product_uploads/CtBZAqc5hVTLe8gkCLb2zsipQb2cyOMa.jpg", MenuId = chickenBurger.Id });
                restaurant.Menus.Add(chickenBurger);

                // Section: Chicken 🍗
                var chicken = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Chicken 🍗",
                    RestaurantId = restaurant.Id
                };
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "6 pc. Chicken Wings", Description = "", Price = 180.00m, ImageUrl = "https://www.korpa.ba/product_uploads/1YxAZ01ZgjITn2Hl2W44Wlz7TBf0myI8.jpg", MenuId = chicken.Id });
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "9 pc. Chicken Wings", Description = "", Price = 230.00m, ImageUrl = "https://www.korpa.ba/product_uploads/rNOjWer7YQSBnwLFJr2VzkPcMYPmkVcK.jpg", MenuId = chicken.Id });
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "6 pc. Nuggets + F. Fries", Description = "", Price = 180.00m, ImageUrl = "https://www.korpa.ba/product_uploads/kAKbsinuBDX3Sef6WEsEEJnlyJ4BLEvx.jpg", MenuId = chicken.Id });
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "9 pc. Nuggets + F. Fries", Description = "", Price = 230.00m, ImageUrl = "https://www.korpa.ba/product_uploads/5SwAjKhtqH48TyIkf7Lez1i8X3nW9Y5Z.jpg", MenuId = chicken.Id });
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "15 pc. Nuggets + F. Fries", Description = "", Price = 350.00m, ImageUrl = "https://www.korpa.ba/product_uploads/j0avvQDXGLUnRBO2lHhMpW27Y4SzM8ms.jpg", MenuId = chicken.Id });
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "6 pc.  Hot Chicken Wings", Description = "", Price = 180.00m, ImageUrl = "https://www.korpa.ba/product_uploads/wUzLsdUx7j13fYvcsOcSNrB6HoHHg6lP.jpg", MenuId = chicken.Id });
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "9 pc. Hot Chicken Wings", Description = "", Price = 230.00m, ImageUrl = "https://www.korpa.ba/product_uploads/J0oE1O9AiXOM4qWAFrojwJVweWMI7KBz.jpg", MenuId = chicken.Id });
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "4 pc. Chili Cheese Nuggets", Description = "", Price = 90.00m, ImageUrl = "https://www.korpa.ba/product_uploads/fD4EJyS5LMRGln7KBk1v4x0c6jUVgXWo.jpg", MenuId = chicken.Id });
                chicken.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "7 pc.  Chili Cheese Nuggets", Description = "", Price = 130.00m, ImageUrl = "https://www.korpa.ba/product_uploads/vJ7orfDwIef0E61V8cvN0DVEwlARvbuT.jpg", MenuId = chicken.Id });
                restaurant.Menus.Add(chicken);

                // Section: Wrap 🌯
                var wrap = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Wrap 🌯",
                    RestaurantId = restaurant.Id
                };
                wrap.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Royal Wrap", Description = "Тортиља, марула, розев сос, домат, две парчиња поховано пилешко, кари сос", Price = 185.00m, ImageUrl = "https://www.korpa.ba/product_uploads/YD958eiggOHJudT8m7cReqVzwPQ2FIrP.jpg", MenuId = wrap.Id });
                restaurant.Menus.Add(wrap);

                // Section: Hot Dog 🌭
                var hotdog = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Hot Dog 🌭",
                    RestaurantId = restaurant.Id
                };
                hotdog.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Chicago Hot Dog", Description = "Лепче, кромид, домат, кечап, кари сос, виршла, розев сос, кисели краставички", Price = 140.00m, ImageUrl = "https://www.korpa.ba/product_uploads/R51iUFi3uTqZDbpOmBQaDhxZVNhzZinV.jpg", MenuId = hotdog.Id });
                restaurant.Menus.Add(hotdog);

                // Section: Fish 🐠
                var fish = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Fish 🐠",
                    RestaurantId = restaurant.Id
                };
                fish.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Fish Burger", Description = "Лепче, кромид, домат, кари сос, кисели краставички, похована риба, розев сос, марула", Price = 215.00m, ImageUrl = "https://www.korpa.ba/product_uploads/iE2jp46jwqUsS4s6XrbJJsARjgQBOLrG.jpg", MenuId = fish.Id });
                fish.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Calamari Burger", Description = "Лепче, кромид, домат, тартар сос, 5 лигњи, розев сос, марула, лепче", Price = 195.00m, ImageUrl = "https://www.korpa.ba/product_uploads/C0zPw3UiUPTB2KsWSsDd3Q9oSb32mNBF.jpg", MenuId = fish.Id });
                restaurant.Menus.Add(fish);

                // Section: Salad 🥙
                var salad = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Salad 🥙",
                    RestaurantId = restaurant.Id
                };
                salad.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Caesar Salad", Description = "Сецкан стек x 2, кубети, доматни коцки, розев сос, марула", Price = 220.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Uy2O2bOBUwqrpMsaCcqNZhq70EHdm64I.jpg", MenuId = salad.Id });
                salad.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Chicken Salad", Description = "Похован стек, доматни коцки, розев сос, марула", Price = 230.00m, ImageUrl = "https://www.korpa.ba/product_uploads/uoSPTMTi1oiUOhq8831bvaaezEsno1sS.jpg", MenuId = salad.Id });
                salad.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Coral Salad", Description = "Поховани лигњи x 4, пченка, доматни коцки, розев сос, марула", Price = 220.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Djp9GMHWQK4wiXbNdK9m106ecnzECaUk.jpg", MenuId = salad.Id });
                restaurant.Menus.Add(salad);

                // Section: Kids Menu 🌈
                var kids = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Kids Menu 🌈",
                    RestaurantId = restaurant.Id
                };
                kids.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Kids Burger Menu", Description = "Бургер со плескавица, помфрит, детско сокче + играчка", Price = 210.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xzMcvB0PwrHz1xPr1YoGSY50O1Do0qET.jpg", MenuId = kids.Id });
                kids.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Kids Chicken Menu", Description = "Бургер со печен или похован стек, помфрит, детско сокче + играчка", Price = 210.00m, ImageUrl = "https://www.korpa.ba/product_uploads/btljPt9xFA4pMs3VDybgcg6DMa1KCEwZ.jpg", MenuId = kids.Id });
                restaurant.Menus.Add(kids);

                // Section: Extras 🍟
                var extras = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Extras 🍟",
                    RestaurantId = restaurant.Id
                };
                extras.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Small French Fries", Description = "", Price = 70.00m, ImageUrl = "https://www.korpa.ba/product_uploads/6PaI7IPlMnDsW7grOPGY8vFtR7LOUW4F.jpg", MenuId = extras.Id });
                extras.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Big French Fries", Description = "", Price = 90.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Xd6JgWP1j83pl8vj1cnfIpjn9HsADs0k.jpg", MenuId = extras.Id });
                extras.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Small Canoe French Fries", Description = "", Price = 80.00m, ImageUrl = "https://www.korpa.ba/product_uploads/CzK3ZJX6vjUSaXWJ8vkAOoeiglOGMSxM.jpg", MenuId = extras.Id });
                extras.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Big Canoe French Fries", Description = "", Price = 100.00m, ImageUrl = "https://www.korpa.ba/product_uploads/C5afYF0FjDt3aNOB797HbNZdZK0jgZzs.jpg", MenuId = extras.Id });
                extras.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кари Сос", Description = "", Price = 25.00m, ImageUrl = "https://www.korpa.ba/product_uploads/3ZXVrSFOPradBHi9Qe9JLbWPPiGgeixH.jpg", MenuId = extras.Id });
                extras.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Розев Сос", Description = "", Price = 25.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ivGDufQMIg0RWG5MTiWOPmQ3eJroUcCq.jpg", MenuId = extras.Id });
                extras.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Кечап", Description = "", Price = 25.00m, ImageUrl = "https://www.korpa.ba/product_uploads/g8XRHyB1iCaIhsfqtwOuwWIWFcoV3QGC.jpg", MenuId = extras.Id });
                restaurant.Menus.Add(extras);

                // Section: Drinks 🥤
                var drinks = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Drinks 🥤",
                    RestaurantId = restaurant.Id
                };
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Coca Cola 0.45", Description = "", Price = 70.00m, ImageUrl = "https://www.korpa.ba/product_uploads/NNBIJtovHgCa8weAqgJAYBHLHiNuzNkH.jpg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Coca Cola 0.33", Description = "", Price = 60.00m, ImageUrl = "https://www.korpa.ba/product_uploads/uf23v7HXawRkHwCOQvfUa3gz2SfxaWXg.jpg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Fanta 0.33", Description = "", Price = 60.00m, ImageUrl = "https://www.korpa.ba/product_uploads/ik2mM9FwIt3F3Y53a4EzdA6D3K7ANQSU.jpg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Fanta 0.45", Description = "", Price = 70.00m, ImageUrl = "https://www.korpa.ba/product_uploads/uR93rozpCz3moCzdO68lZ7VrQVKEbDeC.jpg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Sprite 0.33", Description = "", Price = 60.00m, ImageUrl = "https://www.korpa.ba/product_uploads/3NVA3IlqU3wYzKcASiSTzEO80qu4G4dP.jpg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Sprite 0.45", Description = "", Price = 70.00m, ImageUrl = "https://www.korpa.ba/product_uploads/qGp9Fa9OP19HCTWAyZ2xeIQkMndn9Egw.jpg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Schweppes 0.33", Description = "", Price = 60.00m, ImageUrl = "https://www.korpa.ba/product_uploads/TuHHIbuHzm7I88YptVi5MXGojfBBJLHC.jpeg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Schweppes 0.5", Description = "", Price = 70.00m, ImageUrl = "https://www.korpa.ba/product_uploads/Ea9p8neavQPkkfTbGTysEeNvVmlGSPis.jpg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Rosa 0.5", Description = "", Price = 50.00m, ImageUrl = "https://www.korpa.ba/product_uploads/3AY0aGXqy7w6an7v9g7UZdJ0Gdy11F1w.png", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Fuze Ice Tea Peach 0.5", Description = "", Price = 80.00m, ImageUrl = "https://www.korpa.ba/product_uploads/XOBrkUGEIP3yD4ypjvjXB2XsbnA6lf3y.png", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Fuze Ice Tea Lemon 0.5", Description = "", Price = 80.00m, ImageUrl = "https://www.korpa.ba/product_uploads/GzfsWI7V3XHnB0XcJZK3dOTwE4pybhMr.png", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Next Joy Bozel 0.5", Description = "", Price = 80.00m, ImageUrl = "https://www.korpa.ba/product_uploads/yF9mPWammmt9BVgxpsm1xs7FihOwYkAH.png", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Next Joy Cherry 0.5", Description = "", Price = 80.00m, ImageUrl = "https://www.korpa.ba/product_uploads/xGK07JL7CImZ4Ef0u1QNnSc2Dt66GbyF.png", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Next Lemonade 0.4", Description = "", Price = 80.00m, ImageUrl = "https://www.korpa.ba/product_uploads/4JhMrjmPcgGTrXpg6YZmDIGXDkrocrMi.jpg", MenuId = drinks.Id });
                drinks.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Next Lemonade Mint 0.4", Description = "", Price = 80.00m, ImageUrl = "https://www.korpa.ba/product_uploads/7jKFnjoLGEZjVfGUcdwMqzIHj99y5pLM.jpg", MenuId = drinks.Id });
                restaurant.Menus.Add(drinks);

                // Section: Beer 🍺
                var beer = new Menu
                {
                    Id = Guid.NewGuid(),
                    Title = "Beer 🍺",
                    RestaurantId = restaurant.Id
                };
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Heineken 0.33", Description = "", Price = 90.00m, ImageUrl = "https://www.korpa.ba/product_uploads/HOUzmNeZYRpRxz6GivdfeT5dci4QWMl8.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Skopsko 0.33", Description = "", Price = 80.00m, ImageUrl = "https://www.korpa.ba/product_uploads/af9vqKg7OWxXVuOhfqhHam7HSJa85gzU.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Skopsko 0.5", Description = "", Price = 90.00m, ImageUrl = "https://www.korpa.ba/product_uploads/TaSyOSYU3pf0TW3tQibkZpVr7MLj9kir.jpg", MenuId = beer.Id });
                beer.Items.Add(new MenuItem { Id = Guid.NewGuid(), Name = "Amstel 0.33", Description = "", Price = 90.00m, ImageUrl = "https://www.korpa.ba/product_uploads/s68J5ZnofrVfkqrH44GoqXZMKlTfjZgs.png", MenuId = beer.Id });
                restaurant.Menus.Add(beer);

                restaurant.Menus ??= new List<Menu>();
                restaurantList.Add(restaurant);
            }

            return restaurantList;
        }
    }
}