using SeresProducoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes
{
    public static class DbSeedingClass
    {
        public static void SeedDataContext(this AppDbContext context)
        {
            var Artists = new List<Artist>()
            {
                new Artist
                {
                    Name = "DANYKAS DJ",
                    Bio = "DANYKAS DJ was born in Lisbon, Portugal. The love of music has always been a constant in her life. "
                    + " A musical spirit cultivated by her father, a passion that exists in the whole family. At 11 years, she began to have "
                    + "her interest in the world of DJ’ing when they got to watch the festivities that were held by the group’s DJ Black Project, "
                    + "where two of her brothers in-laws were participating. These approaches to parties shaped her musical background and made this "
                    + "adventure in dj’ing a reality. Since 2012, she was increasing the willingness to take the aspect of music to seriously, "
                    + "dedicating it longer, and Dj Satelite's invitation came in for her to join the Room System project, an opportunity to expose "
                    + "all this feeling through music, to get to the spirits of the people.",
                    Image = "~/images/artists/DANYKAS.jpg",
                    FacebookLink = "https://www.facebook.com/danykasdj/",
                    TwitterLink = "https://twitter.com/danykasdj",
                    SoundCloudLink = "https://soundcloud.com/danykasdj"
                },
                new Artist
                {
                    Name = "DJ Satelite",
                    Bio = "DJ Satelite, a native of Luanda, started his career by raw, passionate curiosity and quickly became one of the main drivers "
                    + "of Afro House and Kuduro in many lusophone countries. After dedicating years on his own productions, in 2006 he achieved "
                    + "notoriety as one of the co-producers of the album Estado Maior do Kuduro dos Lambas. It is also known as the first album "
                    + "produced by a local artist and gained stellar reviews in Angola. In particular, the hit single, ‘Se desfio’ conquered the "
                    + "hearts of a huge fan base. Satelite’s productions have been featured on the critically acclaimed film ‘I Love Kuduro’. "
                    + "Internationally acclaimed as one of the most prominent Angolan beatmakers, He also launched his own record label, Seres "
                    + "Produções in order to expose extraordinary music, including his new release ‘If Only’ with the Moroccan producer Cee "
                    + "ElAssaad. 2016 was an exceptional year of top quality releases with additional productions such as ‘Malembe na "
                    + "Soukouss’, ‘Abantu’ & ‘Xe Mana Bella’. Including collaborations with Ancestral Soul master Boddhi Satva and the unique "
                    + "voice of Freddy Massamba, released by the globally recognized label Offering Recordings. Satelite’s journey has taken him "
                    + "to some of the biggest events and organizations, such as Red Bull Music Academy and the Ibiza International Music Summit. "
                    + "He also got to show his live skills on Boiler Room, alongside Batida. He has also graced some established and "
                    + "innovative festivals such as Sfinks Festival, AfricaNouveau and the Ten Cities project. He has played for the legendary "
                    + "British DJ Fatboy Slim. DJ Satelite is an ambassador of the new Angolan sound and a pioneer of the African Electronic Music "
                    + "scene that burns dance floors all across the globe.",
                    Image = "~/images/artists/SATELITE.jpg",
                    FacebookLink = "https://www.facebook.com/OfficialDJSatelite",
                    TwitterLink = "https://twitter.com/djsatelite_",
                    SoundCloudLink = "https://soundcloud.com/djsatelite"
                },
                new Artist
                {
                    Name = "INAMI",
                    Bio = "Inami is an Artist/Singer/Songwriter/performer/instrumentalist/producer/vocal trainer based in Africa (Nairobi – Kenya). "
                    + "INAMI simply means the Inner me and stands for IN me African Music Inspired. Internationally acclaimed as the first Lady "
                                + "of Equatorial House Music, Inami is a passionate and driven Kenyan musician who is slowly taking over and further "
                                + "strengthening its position, in the movement of house music in Nairobi to the world. Her first release was in February 2013 "
                                + "where she collaborated with Boneless (A Kenyan kamba House artist) on the song ‘Supasta’, produced by Saint Evo. The song "
                                + "was a Kamba tune based on the notion, that all people are born superstars and we can achieve that status, only if we believe "
                                + "in ourselves. Her smooth vocals and catchy hook in collaboration with Boneless’ rapping drove the track and made it a hit. "
                                + "A follow up video to ‘Supasta’ was released thereafter. With the great reception locally and airplay from radio to TV stations, "
                                + "the track ushered Inami into the Kenyan music scene. Mid 2013 saw the release of her first Equatorial House music Debut EP "
                                + "Album, under Celsius Degree Entertainment, titled Little Lost. The EP was inspired by the theme Love, peace and music and is "
                                + "made up of four songs which include: Little Lost, Constant Craving, Musiq Lingo and Peace. The Ep received great reviews and "
                                + "air play both locally and internationally, from Nairobi to Nigeria, DRC, Colombia, New Delhi, Australia and London. She later "
                                + "that year dropped a single titled “Don’t Look Back” – a soulful house track it’s a jazzy feel, that talked about not letting "
                                + "the past define who we are instead focus on the purpose that we resolved to effect in our futures. ‘Don’t Look Back’ is "
                                + "produced by Marcus Ezra, a drum & bass, house, electronic, progressive and retro music producer and artist of soul Bros Records. "
                                + "In 2014 she was officially signed on to Celsius Degree Entertainment, being the first signed artist of the label. She then "
                                + "released a follow up to the Little lost Ep: Part 2, titled “Little Lost Re-incarnation” which was made up of seven songs and a "
                                + "stunning video of the single titled “constant craving” to her debut EP, Little Lost. The songs included: Little Lost (Acoustic mix) "
                                + "which she co-produced with Saint Evo The Myth, Whispers of Love, Became Mucho(House Version), Constant Craving (Saint Evo’s "
                                + "Lounge Mix), Little Lost(Brackish Remix), Music Lingo (Reprise mix) and Jole. Mid 2014, the hit track ‘supasta’s official "
                                + "remix by Saint Evo was released. In 2015, Inami released an EP titled “Burn Hard” which comprised of the original mix by "
                                + "Saint Evo The Myth and a remix by Melo Mokoena, a producer and artist of Soul Candi Records. The EP was inspired by the "
                                + "theme ‘Love gone sour’ In 2016, the single “constant Craving” was remixed by The Exchange Project, an initiative made up of "
                                + "producers from Angola, Sierra Leone and Kenya aimed at bridging borders with sound. Inami also feature in a song titled, "
                                + "“Mapenzi” on Saint Evo The Myth’s ‘Early Years EP. In April 2016 she featured on Saint Evo’s EP “The Vika Vu EP” that "
                                + "consists of two tracks, namely, “Vika Vu” & “On My Way Home”, featuring the sultry vocals and creative writing of the First "
                                + "Lady Of Equatorial House, Inami. The EP was inspired by the theme, life’s Journey that talked about the firm resolve on a "
                                + "determined soul on a journey to greatness. The EP went global, courtesy of Seres Producoes, a record label in Angola making it "
                                + "available on traxsource, iTunes, Google Play, spotify, YouTube, beatport, junodownload and tidal. Following the Vika Vu Ep, "
                                + "Inami collaborated on a hit single titled ‘All OR Nothing’ produced by DJ Leah SA, a house producer from South Africa that "
                                + "was recently released under Seres Producoes and is now available on traxsource, iTunes, Google Play, Amazon, spotify, YouTube, "
                                + "beatport, junodownload, tidal and deezer. 2016 and 2017 were set to be exceptional years with forth coming releases, an "
                                + "Album as well as her own productions.",
                            Image = "~/images/artists/INAMI.jpg",
                            FacebookLink = "https://www.facebook.com/inamikenya/",
                            TwitterLink = "https://twitter.com/fi_inami ",
                            SoundCloudLink = "https://soundcloud.com/inami-3"
                        },
                        new Artist
                        {
                            Name = "K.O.D",
                            Bio = "K.O.D is a Producer| Artist| Songwriter| Entrepreneur| Philanthropist| Re-mixer and Poet currently residing in Bulawayo "
                                + "(Zimbabwe). Born in Simbarashe Kodzai on August 06 1990, he was introduced to House music in 2003 and was provided the "
                                + "opportunity to record in 2005. He went on to start making his own production in 2008 because he wanted to have full "
                                + "control of his career and creativity. Determined to make a break on the House scene he joined forces with Herbal 3 "
                                + "Records based in South Africa releasing smash hits In The Name Of love and Iculo Lothando which did well on the local "
                                + "scene. Determined to break into the international market he aligns himself with Seres Producoes a record label based "
                                + "in Luanda (Angola). He is heavily influenced by the likes of Kanye West, Grego Salto, Oskido, Black Coffee, Euphonic, "
                                + "Dj Fresh Sa, Ganyani, and Black Motion in the same level of work ethic. K.O.D (King Of Drums) is a self motivated "
                                + "individual, hard working and God fearing, set to change his life and of those around him with his musical gift.",
                            Image = "~/images/artists/KOD.jpg",
                            FacebookLink = "https://www.facebook.com/KODworldwide/",
                            TwitterLink = "https://twitter.com/KOD_worldwide",
                            SoundCloudLink = "https://soundcloud.com/kod_worldwide"
                        },
                        new Artist
                        {
                            Name = "ROSARIO",
                            Bio = "Rosario, born in Luanda, Angola. Made his debut in the world of House Music in 2011 posting sets of Afro House on "
                                + "soundcloud by the Mbambu Records group ( with Dj Nax and Braga Havaiana). Later in 2012 he joined “Tainted House "
                                + "Records”, based in South Africa, where he released several projects such as “Kalunga Kianda” with Braga Havaina "
                                + "and “Destiny” with Jackie Queens.And several remixes on tracks like “Roots” and “Tyityimba” authored by Rune Sibiya, "
                                + "and “You Don’t Deserve Me” by Reel Skaps(Global Deep Recordings). Currently in Mbambu Records group known as the "
                                + "author of the hits songs “Me Mata” (with Dj Jesus) and “Tatau” (with Bebucho Q Kuia), and other projects that are "
                                + "having a high impact on today’s african house scene. Later he meets with Dj Satelite on the record label "
                                + "”Seres Produções” from Angola, becoming a member on the label, releasing tracks in collaboration with South African a"
                                + "rtists like Jackie Queens and Lebo Snookums with whom he released the single ‘Silly Of Me”and other projects.",
                            Image = "~/images/artists/ROSARIO.jpg",
                            FacebookLink = "https://www.facebook.com/Rosariokalenga",
                            TwitterLink = "https://twitter.com/rosariokalenga",
                            SoundCloudLink = "https://soundcloud.com/rosariokalenga"
                        },
                        new Artist
                        {
                            Name = "WILSON KENTURA",
                            Bio = "(Felisberto Arthur) a young Talented, born in Luanda (Angola), Dj and producer of Music house which his name does not "
                                + "ass unnoticed in the Angolan music, specifically in the style house Music. His passion for the art of music began at "
                                + "age 14 and had as their major influences artists like John Legend, Atjazz, Salif Keita, Michael Jackson, Dennis Ferrer, "
                                + "Bob Sinclar, Phil Collins, Kassav, Daft Punk and many others. In his career as a music producer, went through many styles "
                                + "including: Kuduro, Rap, Kizomba and finally his passion for art quickened in House music. Considered as one of the "
                                + "mentors of souful style and african - house in Angola. His remixes and His songs touch on several radio and television "
                                + "channels, having already launched several themes on various labels such as: Arrecha Records, Oluwki Music, "
                                + "“Seres Produções (where he is currently a member and partner), and many others. Throughout his career, Wilson has been "
                                + "present in Several bars and clubs COUNTRY and beyond. In 2012 he decided to join with other Angolan producer name Tiuze "
                                + "Money, with whom he formed the label VOZES QUENTES, where launched and have launched many musical themes rolling in "
                                + "Angola and in the world outside is expected to more than double in the coming months and years, and it is believed that "
                                + "could be heading for a great way to success!",
                            Image = "~/images/artists/WILSON.jpg",
                            FacebookLink = "https://www.facebook.com/djwilsonkentura",
                            TwitterLink = "https://twitter.com/wilsonkentura",
                            SoundCloudLink = "https://soundcloud.com/wilson-kentura"
                        }
            };
            var Articles = new List<Article>()
            {
                new Article
                        {
                            Headline = "Music can unite and spread more...",
                            Content = "Alexandros Djkevingr & Greg Ignatovich (Parquet Recordings, Diynamic) from Greek came up with the idea for a big "
                                    + "collaboration that unites different countries and music styles from all over the world...",
                            Date = new DateTime(2020, 2, 29),
                            Image = "~/images/articles/n01.jpeg",
                            Link = "https://medium.com/@seresproducoes/alexandros-djkevingr-greg-ignatovich-vs-bruce-leroys-and-daniel-rateuke-that-music-can-9cac40c4d013"
                        },
                        new Article
                        {
                            Headline = "Curitiba on Afro House map with the Brazilian duo Drunky Daniels.",
                            Content = "Drunky Daniels estão de Volta depois do Album ‘’Zabumba’’ lancado no ano passado com destaque na Mixmag, Bantumen e "
                                    + "muito outros magazines. A Seres Producões apresenta o seu mais recente Single dos Drunky Daniels, com origens bem "
                                    + "brasileiras viajando por drums africanos...",
                            Date = new DateTime(2020, 2, 19),
                            Image = "~/images/articles/n02.jpeg",
                            Link = "https://medium.com/@seresproducoes/curitiba-on-afro-house-map-with-the-brazilian-duo-drunky-daniels-617e22f2cfeb"
                        },
                        new Article
                        {
                            Headline = "Duo Two Strong starting the year in Force.",
                            Content = "There’s something in the Two Strong duo, that’s making their music growing each day at the Angolan music scene and "
                                    + "places around the world...",
                            Date = new DateTime(2020, 2, 15),
                            Image = "~/images/articles/n03.jpeg",
                            Link = "https://medium.com/@seresproducoes/duo-two-strong-starting-the-year-in-force-37cfa7480f39"
                        },
                        new Article
                        {
                            Headline = "“Can’t Stay Away EP” Tswex Malabola!",
                            Content = "Tswelelo ‘Tswex’ Malabola is a self taught underground house music producer.The diversity in his sound comes from "
                                    + "the inspiration brought by listening to different genres. His love for house music started from an early age of 11 "
                                    + "years and following that, he was able to start producing as well...",
                            Date = new DateTime(2020, 2, 6),
                            Image = "~/images/articles/n04.jpeg",
                            Link = "https://medium.com/@seresproducoes/cant-stay-away-ep-tswex-malabola-ff37e96bcec2"
                        },
                        new Article
                        {
                            Headline = "Today Sonar has his fingerprints in our humble home.",
                            Content = "Sonar born of African-Shangani descent in Cottondale Acornhoek Bushbuckridge. Sonar loved to sing and make music and "
                                    + "his teacher would constantly cite him for disturbing the peace of the classroom through his spontaneous need to tap "
                                    + "rhythms on whatever he had on hand...",
                            Date = new DateTime(2020, 2, 3),
                            Image = "~/images/articles/n05.jpeg",
                            Link = "https://medium.com/@seresproducoes/today-sonar-has-his-fingerprints-in-our-humble-home-3783cc9e20ba"
                        }
            };
            var Releases = new List<Release>()
            {
                  new Release
                        {
                            Title = "KOMANTA",
                            Artist = "ERAN YAARI",
                            Link = "https://www.traxsource.com/title/1288428/komanta",
                            Image = "~/images/releases/1_Komanta.jpg"
                        },
                        new Release
                        {
                            Title = "ZONA VERMELHA",
                            Artist = "SATELITE & K.O.D",
                            Link = "https://www.traxsource.com/title/1288476/zona-vermelha",
                            Image = "~/images/releases/2_Zona.jpg"
                        },
                        new Release
                        {
                            Title = "BLACK CURSE OF SARAPAST",
                            Artist = "ALEXANDROS DJKEVINGR & GREG IGNATOVICH, BRUCE LEROYS, DANIEL RATEUK",
                            Link = "https://www.traxsource.com/title/1288475/black-curse-of-sarapast",
                            Image = "~/images/releases/3_BlackCurse.jpg"
                        },
                        new Release
                        {
                            Title = "JANAINA",
                            Artist = "DRUNKY DANIELS",
                            Link = "https://www.traxsource.com/title/1280077/janaina",
                            Image = "~/images/releases/4_Janaina.jpg"
                        },
                        new Release
                        {
                            Title = "CAN'T STAY AWAY EP",
                            Artist = "TSWEX MALABOLA",
                            Link = "https://www.traxsource.com/title/1272414/cant-stay-away-ep",
                            Image = "~/images/releases/5_CantStayAway.jpg"
                        },
                        new Release
                        {
                            Title = "OBCECADO EP",
                            Artist = "2 STRONG",
                            Link = "https://www.traxsource.com/title/1281222/obcecado-ep",
                            Image = "~/images/releases/6_obcecado.jpg"
                        },
                        new Release
                        {
                            Title = "MOJO",
                            Artist = "ROSARIO",
                            Link = "https://www.traxsource.com/title/1264053/mojo",
                            Image = "~/images/releases/7_mojo.jpg"
                        },
                        new Release
                        {
                            Title = "MORE LIFE",
                            Artist = "SONAR ft. TIKWE",
                            Link = "https://www.traxsource.com/title/1272046/more-life",
                            Image = "~/images/releases/8_MoreLife.jpg"
                        }
            };
            var Events = new List<Event>()
            {
                new Event
                        {
                            Name = "DJ Satelite + Danykas DJ",
                            Host = "Hosted by Seres Produções, MUSICBOX LISBOA, DJ Satelite, DANYKAS DJ",
                            Date = new DateTime(2020, 2, 27),
                            DescriptiveDate = "Thursday, February 27, 2020 at 11:59 PM – 6 AM UTC",
                            Link = null,
                            Image = "~/images/events/e1.jpg"
                        },
                        new Event
                        {
                            Name = "Batida b2b Satelite",
                            Host = "Hosted by Lux Frágil and Batida",
                            Date = new DateTime(2020, 1, 16),
                            DescriptiveDate = "Thursday, January 16, 2020 at 11:45 PM – 6 AM UTC",
                            Link = null,
                            Image = "~/images/events/e2.jpg"
                        },
                        new Event
                        {
                            Name = "Rádio Quântica: Lsdxoxo x Danykas x Prec x Poly Garbo x Pachinko",
                            Host = "Hosted by Lux Frágil and Rádio Quântica",
                            Date = new DateTime(2020, 1, 9),
                            DescriptiveDate = "Thursday, January 9, 2020 at 11:45 PM – 6 AM UTC",
                            Link = null,
                            Image = "~/images/events/e3.jpg"
                        },
                        new Event
                        {
                            Name = "Room System #8",
                            Host = "Hosted by Room System, Village Underground Lisboa",
                            Date = new DateTime(2019, 12, 14),
                            DescriptiveDate = "Saturday, December 14, 2019 at 11:55 PM – 6 AM UTC",
                            Link = "https://www.residentadvisor.net/events/1348378?fbclid=IwAR2VzS6jFFBotx6I3p1KO2MnzrpkWcocCjgakDZpr1oHT7zR4sfpKGorONU.",
                            Image = "~/images/events/e4.jpg"
                        }
            };

            context.Artists.AddRange(Artists);
            context.Articles.AddRange(Articles);
            context.Releases.AddRange(Releases);
            context.Events.AddRange(Events);
            context.SaveChanges();
        }        
    }
}
