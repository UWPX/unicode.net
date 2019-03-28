using System.Collections.Generic;

namespace NeoSmart.Unicode
{
    // This file is machine-generated based on the official Unicode Consortium publication (https://unicode.org/Public/emoji/12.0/emoji-test.txt).
    // See https://github.com/UWPX/Emoji-List-Parser for the generator.
    public static partial class Emoji
    {
        /// <summary>
        /// A (sorted) enumeration of all emoji without skin variations and no duplicate gendered vs gender-neutral emoji, ideal for displaying.
        /// Emoji without supported glyphs in Segoe UI Emoji are also omitted from this list.
        /// <summary>
#if NET20 || NET30 || NET35
        public static readonly List<SingleEmoji> Basic = new List<SingleEmoji>() {
#else
        public static SortedSet<SingleEmoji> Basic => new SortedSet<SingleEmoji>() {
#endif
            /* 😀 */ GrinningFace,
            /* 😃 */ GrinningFaceBigEyes,
            /* 😄 */ GrinningFaceSmilingEyes,
            /* 😁 */ BeamingFaceSmilingEyes,
            /* 😆 */ GrinningSquintingFace,
            /* 😅 */ GrinningFaceSweat,
            /* 🤣 */ RollingFloorLaughing,
            /* 😂 */ FaceTearsJoy,
            /* 🙂 */ SlightlySmilingFace,
            /* 🙃 */ UpsideDownFace,
            /* 😉 */ WinkingFace,
            /* 😊 */ SmilingFaceSmilingEyes,
            /* 😇 */ SmilingFaceHalo,
            /* 🥰 */ SmilingFaceHearts,
            /* 😍 */ SmilingFaceHeartEyes,
            /* 🤩 */ StarStruck,
            /* 😘 */ FaceBlowingAKiss,
            /* 😗 */ KissingFace,
            /* 😚 */ KissingFaceClosedEyes,
            /* 😙 */ KissingFaceSmilingEyes,
            /* 😋 */ FaceSavoringFood,
            /* 😛 */ FaceTongue,
            /* 😜 */ WinkingFaceTongue,
            /* 🤪 */ ZanyFace,
            /* 😝 */ SquintingFaceTongue,
            /* 🤑 */ MoneyMouthFace,
            /* 🤗 */ HuggingFace,
            /* 🤭 */ FaceHandOverMouth,
            /* 🤫 */ ShushingFace,
            /* 🤔 */ ThinkingFace,
            /* 🤐 */ ZipperMouthFace,
            /* 🤨 */ FaceRaisedEyebrow,
            /* 😐 */ NeutralFace,
            /* 😑 */ ExpressionlessFace,
            /* 😶 */ FaceMouth,
            /* 😏 */ SmirkingFace,
            /* 😒 */ UnamusedFace,
            /* 🙄 */ FaceRollingEyes,
            /* 😬 */ GrimacingFace,
            /* 🤥 */ LyingFace,
            /* 😌 */ RelievedFace,
            /* 😔 */ PensiveFace,
            /* 😪 */ SleepyFace,
            /* 🤤 */ DroolingFace,
            /* 😴 */ SleepingFace,
            /* 😷 */ FaceMedicalMask,
            /* 🤒 */ FaceThermometer,
            /* 🤕 */ FaceHeadBandage,
            /* 🤢 */ NauseatedFace,
            /* 🤮 */ FaceVomiting,
            /* 🤧 */ SneezingFace,
            /* 🥵 */ HotFace,
            /* 🥶 */ ColdFace,
            /* 🥴 */ WoozyFace,
            /* 😵 */ DizzyFace,
            /* 🤯 */ ExplodingHead,
            /* 🤠 */ CowboyHatFace,
            /* 🥳 */ PartyingFace,
            /* 😎 */ SmilingFaceSunglasses,
            /* 🤓 */ NerdFace,
            /* 🧐 */ FaceMonocle,
            /* 😕 */ ConfusedFace,
            /* 😟 */ WorriedFace,
            /* 🙁 */ SlightlyFrowningFace,
            /* 😮 */ FaceOpenMouth,
            /* 😯 */ HushedFace,
            /* 😲 */ AstonishedFace,
            /* 😳 */ FlushedFace,
            /* 🥺 */ PleadingFace,
            /* 😦 */ FrowningFaceOpenMouth,
            /* 😧 */ AnguishedFace,
            /* 😨 */ FearfulFace,
            /* 😰 */ AnxiousFaceSweat,
            /* 😥 */ SadButRelievedFace,
            /* 😢 */ CryingFace,
            /* 😭 */ LoudlyCryingFace,
            /* 😱 */ FaceScreamingFear,
            /* 😖 */ ConfoundedFace,
            /* 😣 */ PerseveringFace,
            /* 😞 */ DisappointedFace,
            /* 😓 */ DowncastFaceSweat,
            /* 😩 */ WearyFace,
            /* 😫 */ TiredFace,
            /* 😤 */ FaceSteamFromNose,
            /* 😡 */ PoutingFace,
            /* 😠 */ AngryFace,
            /* 🤬 */ FaceSymbolsMouth,
            /* 😈 */ SmilingFaceHorns,
            /* 👿 */ AngryFaceHorns,
            /* 💀 */ Skull,
            /* 💩 */ PilePoo,
            /* 🤡 */ ClownFace,
            /* 👹 */ Ogre,
            /* 👺 */ Goblin,
            /* 👻 */ Ghost,
            /* 👽 */ Alien,
            /* 👾 */ AlienMonster,
            /* 🤖 */ Robot,
            /* 😺 */ GrinningCat,
            /* 😸 */ GrinningCatSmilingEyes,
            /* 😹 */ CatTearsJoy,
            /* 😻 */ SmilingCatHeartEyes,
            /* 😼 */ CatWrySmile,
            /* 😽 */ KissingCat,
            /* 🙀 */ WearyCat,
            /* 😿 */ CryingCat,
            /* 😾 */ PoutingCat,
            /* 🙈 */ SeeNoEvilMonkey,
            /* 🙉 */ HearNoEvilMonkey,
            /* 🙊 */ SpeakNoEvilMonkey,
            /* 💋 */ KissMark,
            /* 💌 */ LoveLetter,
            /* 💘 */ HeartArrow,
            /* 💝 */ HeartRibbon,
            /* 💖 */ SparklingHeart,
            /* 💗 */ GrowingHeart,
            /* 💓 */ BeatingHeart,
            /* 💞 */ RevolvingHearts,
            /* 💕 */ TwoHearts,
            /* 💟 */ HeartDecoration,
            /* 💔 */ BrokenHeart,
            /* 🧡 */ OrangeHeart,
            /* 💛 */ YellowHeart,
            /* 💚 */ GreenHeart,
            /* 💙 */ BlueHeart,
            /* 💜 */ PurpleHeart,
            /* 🖤 */ BlackHeart,
            /* 💯 */ HundredPoints,
            /* 💢 */ AngerSymbol,
            /* 💥 */ Collision,
            /* 💫 */ Dizzy,
            /* 💦 */ SweatDroplets,
            /* 💨 */ DashingAway,
            /* 💣 */ Bomb,
            /* 💬 */ SpeechBalloon,
            /* 💭 */ ThoughtBalloon,
            /* 💤 */ Zzz,
            /* 👋 */ WavingHand,
            /* 🤚 */ RaisedBackHand,
            /* ✋ */ RaisedHand,
            /* 🖖 */ VulcanSalute,
            /* 👌 */ OkHand,
            /* 🤞 */ CrossedFingers,
            /* 🤟 */ LoveYouGesture,
            /* 🤘 */ SignHorns,
            /* 🤙 */ CallMeHand,
            /* 👈 */ BackhandIndexPointingLeft,
            /* 👉 */ BackhandIndexPointingRight,
            /* 👆 */ BackhandIndexPointingUp,
            /* 🖕 */ MiddleFinger,
            /* 👇 */ BackhandIndexPointingDown,
            /* 👍 */ ThumbsUp,
            /* 👎 */ ThumbsDown,
            /* ✊ */ RaisedFist,
            /* 👊 */ OncomingFist,
            /* 🤛 */ LeftFacingFist,
            /* 🤜 */ RightFacingFist,
            /* 👏 */ ClappingHands,
            /* 🙌 */ RaisingHands,
            /* 👐 */ OpenHands,
            /* 🤲 */ PalmsUpTogether,
            /* 🤝 */ Handshake,
            /* 🙏 */ FoldedHands,
            /* 💅 */ NailPolish,
            /* 🤳 */ Selfie,
            /* 💪 */ FlexedBiceps,
            /* 🦵 */ Leg,
            /* 🦶 */ Foot,
            /* 👂 */ Ear,
            /* 👃 */ Nose,
            /* 🧠 */ Brain,
            /* 🦷 */ Tooth,
            /* 🦴 */ Bone,
            /* 👀 */ Eyes,
            /* 👅 */ Tongue,
            /* 👄 */ Mouth,
            /* 👶 */ Baby,
            /* 🧒 */ Child,
            /* 👦 */ Boy,
            /* 👧 */ Girl,
            /* 🧑 */ Person,
            /* 👱 */ PersonBlondHair,
            /* 👨 */ Man,
            /* 🧔 */ ManBeard,
            /* 👩 */ Woman,
            /* 🧓 */ OlderPerson,
            /* 👴 */ OldMan,
            /* 👵 */ OldWoman,
            /* 🙍 */ PersonFrowning,
            /* 🙎 */ PersonPouting,
            /* 🙅 */ PersonGesturingNo,
            /* 🙆 */ PersonGesturingOk,
            /* 💁 */ PersonTippingHand,
            /* 🙋 */ PersonRaisingHand,
            /* 🙇 */ PersonBowing,
            /* 🤦 */ PersonFacepalming,
            /* 🤷 */ PersonShrugging,
            /* 👮 */ PoliceOfficer,
            /* 💂 */ Guard,
            /* 👷 */ ConstructionWorker,
            /* 🤴 */ Prince,
            /* 👸 */ Princess,
            /* 👳 */ PersonWearingTurban,
            /* 👲 */ ManChineseCap,
            /* 🧕 */ WomanHeadscarf,
            /* 🤵 */ ManTuxedo,
            /* 👰 */ BrideVeil,
            /* 🤰 */ PregnantWoman,
            /* 🤱 */ BreastFeeding,
            /* 👼 */ BabyAngel,
            /* 🎅 */ SantaClaus,
            /* 🤶 */ MrsClaus,
            /* 🦸 */ Superhero,
            /* 🦹 */ Supervillain,
            /* 🧙 */ Mage,
            /* 🧚 */ Fairy,
            /* 🧛 */ Vampire,
            /* 🧜 */ Merperson,
            /* 🧝 */ Elf,
            /* 🧞 */ Genie,
            /* 🧟 */ Zombie,
            /* 💆 */ PersonGettingMassage,
            /* 💇 */ PersonGettingHaircut,
            /* 🚶 */ PersonWalking,
            /* 🏃 */ PersonRunning,
            /* 💃 */ WomanDancing,
            /* 🕺 */ ManDancing,
            /* 👯 */ PeopleBunnyEars,
            /* 🧖 */ PersonSteamyRoom,
            /* 🧗 */ PersonClimbing,
            /* 🤺 */ PersonFencing,
            /* 🏇 */ HorseRacing,
            /* 🏂 */ Snowboarder,
            /* 🏄 */ PersonSurfing,
            /* 🚣 */ PersonRowingBoat,
            /* 🏊 */ PersonSwimming,
            /* 🚴 */ PersonBiking,
            /* 🚵 */ PersonMountainBiking,
            /* 🤸 */ PersonCartwheeling,
            /* 🤼 */ PeopleWrestling,
            /* 🤽 */ PersonPlayingWaterPolo,
            /* 🤾 */ PersonPlayingHandball,
            /* 🤹 */ PersonJuggling,
            /* 🧘 */ PersonLotusPosition,
            /* 🛀 */ PersonTakingBath,
            /* 🛌 */ PersonBed,
            /* 👭 */ WomenHoldingHands,
            /* 👫 */ WomanManHoldingHands,
            /* 👬 */ MenHoldingHands,
            /* 💏 */ Kiss,
            /* 💑 */ CoupleHeart,
            /* 👪 */ Family,
            /* 👤 */ BustSilhouette,
            /* 👥 */ BustsSilhouette,
            /* 👣 */ Footprints,
            /* 🦰 */ RedHair,
            /* 🦱 */ CurlyHair,
            /* 🦳 */ WhiteHair,
            /* 🦲 */ Bald,
            /* 🐵 */ MonkeyFace,
            /* 🐒 */ Monkey,
            /* 🦍 */ Gorilla,
            /* 🐶 */ DogFace,
            /* 🐕 */ Dog,
            /* 🐩 */ Poodle,
            /* 🐺 */ Wolf,
            /* 🦊 */ Fox,
            /* 🦝 */ Raccoon,
            /* 🐱 */ CatFace,
            /* 🐈 */ Cat,
            /* 🦁 */ Lion,
            /* 🐯 */ TigerFace,
            /* 🐅 */ Tiger,
            /* 🐆 */ Leopard,
            /* 🐴 */ HorseFace,
            /* 🐎 */ Horse,
            /* 🦄 */ Unicorn,
            /* 🦓 */ Zebra,
            /* 🦌 */ Deer,
            /* 🐮 */ CowFace,
            /* 🐂 */ Ox,
            /* 🐃 */ WaterBuffalo,
            /* 🐄 */ Cow,
            /* 🐷 */ PigFace,
            /* 🐖 */ Pig,
            /* 🐗 */ Boar,
            /* 🐽 */ PigNose,
            /* 🐏 */ Ram,
            /* 🐑 */ Ewe,
            /* 🐐 */ Goat,
            /* 🐪 */ Camel,
            /* 🐫 */ TwoHumpCamel,
            /* 🦙 */ Llama,
            /* 🦒 */ Giraffe,
            /* 🐘 */ Elephant,
            /* 🦏 */ Rhinoceros,
            /* 🦛 */ Hippopotamus,
            /* 🐭 */ MouseFace,
            /* 🐁 */ Mouse,
            /* 🐀 */ Rat,
            /* 🐹 */ Hamster,
            /* 🐰 */ RabbitFace,
            /* 🐇 */ Rabbit,
            /* 🦔 */ Hedgehog,
            /* 🦇 */ Bat,
            /* 🐻 */ Bear,
            /* 🐨 */ Koala,
            /* 🐼 */ Panda,
            /* 🦘 */ Kangaroo,
            /* 🦡 */ Badger,
            /* 🐾 */ PawPrints,
            /* 🦃 */ Turkey,
            /* 🐔 */ Chicken,
            /* 🐓 */ Rooster,
            /* 🐣 */ HatchingChick,
            /* 🐤 */ BabyChick,
            /* 🐥 */ FrontFacingBabyChick,
            /* 🐦 */ Bird,
            /* 🐧 */ Penguin,
            /* 🦅 */ Eagle,
            /* 🦆 */ Duck,
            /* 🦢 */ Swan,
            /* 🦉 */ Owl,
            /* 🦚 */ Peacock,
            /* 🦜 */ Parrot,
            /* 🐸 */ Frog,
            /* 🐊 */ Crocodile,
            /* 🐢 */ Turtle,
            /* 🦎 */ Lizard,
            /* 🐍 */ Snake,
            /* 🐲 */ DragonFace,
            /* 🐉 */ Dragon,
            /* 🦕 */ Sauropod,
            /* 🦖 */ TRex,
            /* 🐳 */ SpoutingWhale,
            /* 🐋 */ Whale,
            /* 🐬 */ Dolphin,
            /* 🐟 */ Fish,
            /* 🐠 */ TropicalFish,
            /* 🐡 */ Blowfish,
            /* 🦈 */ Shark,
            /* 🐙 */ Octopus,
            /* 🐚 */ SpiralShell,
            /* 🐌 */ Snail,
            /* 🦋 */ Butterfly,
            /* 🐛 */ Bug,
            /* 🐜 */ Ant,
            /* 🐝 */ Honeybee,
            /* 🐞 */ LadyBeetle,
            /* 🦗 */ Cricket,
            /* 🦂 */ Scorpion,
            /* 🦟 */ Mosquito,
            /* 🦠 */ Microbe,
            /* 💐 */ Bouquet,
            /* 🌸 */ CherryBlossom,
            /* 💮 */ WhiteFlower,
            /* 🌹 */ Rose,
            /* 🥀 */ WiltedFlower,
            /* 🌺 */ Hibiscus,
            /* 🌻 */ Sunflower,
            /* 🌼 */ Blossom,
            /* 🌷 */ Tulip,
            /* 🌱 */ Seedling,
            /* 🌲 */ EvergreenTree,
            /* 🌳 */ DeciduousTree,
            /* 🌴 */ PalmTree,
            /* 🌵 */ Cactus,
            /* 🌾 */ SheafRice,
            /* 🌿 */ Herb,
            /* 🍀 */ FourLeafClover,
            /* 🍁 */ MapleLeaf,
            /* 🍂 */ FallenLeaf,
            /* 🍃 */ LeafFlutteringWind,
            /* 🍇 */ Grapes,
            /* 🍈 */ Melon,
            /* 🍉 */ Watermelon,
            /* 🍊 */ Tangerine,
            /* 🍋 */ Lemon,
            /* 🍌 */ Banana,
            /* 🍍 */ Pineapple,
            /* 🥭 */ Mango,
            /* 🍎 */ RedApple,
            /* 🍏 */ GreenApple,
            /* 🍐 */ Pear,
            /* 🍑 */ Peach,
            /* 🍒 */ Cherries,
            /* 🍓 */ Strawberry,
            /* 🥝 */ KiwiFruit,
            /* 🍅 */ Tomato,
            /* 🥥 */ Coconut,
            /* 🥑 */ Avocado,
            /* 🍆 */ Eggplant,
            /* 🥔 */ Potato,
            /* 🥕 */ Carrot,
            /* 🌽 */ EarCorn,
            /* 🥒 */ Cucumber,
            /* 🥬 */ LeafyGreen,
            /* 🥦 */ Broccoli,
            /* 🍄 */ Mushroom,
            /* 🥜 */ Peanuts,
            /* 🌰 */ Chestnut,
            /* 🍞 */ Bread,
            /* 🥐 */ Croissant,
            /* 🥖 */ BaguetteBread,
            /* 🥨 */ Pretzel,
            /* 🥯 */ Bagel,
            /* 🥞 */ Pancakes,
            /* 🧀 */ CheeseWedge,
            /* 🍖 */ MeatBone,
            /* 🍗 */ PoultryLeg,
            /* 🥩 */ CutMeat,
            /* 🥓 */ Bacon,
            /* 🍔 */ Hamburger,
            /* 🍟 */ FrenchFries,
            /* 🍕 */ Pizza,
            /* 🌭 */ HotDog,
            /* 🥪 */ Sandwich,
            /* 🌮 */ Taco,
            /* 🌯 */ Burrito,
            /* 🥙 */ StuffedFlatbread,
            /* 🥚 */ Egg,
            /* 🍳 */ Cooking,
            /* 🥘 */ ShallowPanFood,
            /* 🍲 */ PotFood,
            /* 🥣 */ BowlSpoon,
            /* 🥗 */ GreenSalad,
            /* 🍿 */ Popcorn,
            /* 🧂 */ Salt,
            /* 🥫 */ CannedFood,
            /* 🍱 */ BentoBox,
            /* 🍘 */ RiceCracker,
            /* 🍙 */ RiceBall,
            /* 🍚 */ CookedRice,
            /* 🍛 */ CurryRice,
            /* 🍜 */ SteamingBowl,
            /* 🍝 */ Spaghetti,
            /* 🍠 */ RoastedSweetPotato,
            /* 🍢 */ Oden,
            /* 🍣 */ Sushi,
            /* 🍤 */ FriedShrimp,
            /* 🍥 */ FishCakeSwirl,
            /* 🥮 */ MoonCake,
            /* 🍡 */ Dango,
            /* 🥟 */ Dumpling,
            /* 🥠 */ FortuneCookie,
            /* 🥡 */ TakeoutBox,
            /* 🦀 */ Crab,
            /* 🦞 */ Lobster,
            /* 🦐 */ Shrimp,
            /* 🦑 */ Squid,
            /* 🍦 */ SoftIceCream,
            /* 🍧 */ ShavedIce,
            /* 🍨 */ IceCream,
            /* 🍩 */ Doughnut,
            /* 🍪 */ Cookie,
            /* 🎂 */ BirthdayCake,
            /* 🍰 */ Shortcake,
            /* 🧁 */ Cupcake,
            /* 🥧 */ Pie,
            /* 🍫 */ ChocolateBar,
            /* 🍬 */ Candy,
            /* 🍭 */ Lollipop,
            /* 🍮 */ Custard,
            /* 🍯 */ HoneyPot,
            /* 🍼 */ BabyBottle,
            /* 🥛 */ GlassMilk,
            /* ☕ */ HotBeverage,
            /* 🍵 */ TeacupHandle,
            /* 🍶 */ Sake,
            /* 🍾 */ BottlePoppingCork,
            /* 🍷 */ WineGlass,
            /* 🍸 */ CocktailGlass,
            /* 🍹 */ TropicalDrink,
            /* 🍺 */ BeerMug,
            /* 🍻 */ ClinkingBeerMugs,
            /* 🥂 */ ClinkingGlasses,
            /* 🥃 */ TumblerGlass,
            /* 🥤 */ CupStraw,
            /* 🥢 */ Chopsticks,
            /* 🍴 */ ForkKnife,
            /* 🥄 */ Spoon,
            /* 🔪 */ KitchenKnife,
            /* 🏺 */ Amphora,
            /* 🌍 */ GlobeShowingEuropeAfrica,
            /* 🌎 */ GlobeShowingAmericas,
            /* 🌏 */ GlobeShowingAsiaAustralia,
            /* 🌐 */ GlobeMeridians,
            /* 🗾 */ MapJapan,
            /* 🧭 */ Compass,
            /* 🌋 */ Volcano,
            /* 🗻 */ MountFuji,
            /* 🧱 */ Brick,
            /* 🏠 */ House,
            /* 🏡 */ HouseGarden,
            /* 🏢 */ OfficeBuilding,
            /* 🏣 */ JapanesePostOffice,
            /* 🏤 */ PostOffice,
            /* 🏥 */ Hospital,
            /* 🏦 */ Bank,
            /* 🏨 */ Hotel,
            /* 🏩 */ LoveHotel,
            /* 🏪 */ ConvenienceStore,
            /* 🏫 */ School,
            /* 🏬 */ DepartmentStore,
            /* 🏭 */ Factory,
            /* 🏯 */ JapaneseCastle,
            /* 🏰 */ Castle,
            /* 💒 */ Wedding,
            /* 🗼 */ TokyoTower,
            /* 🗽 */ StatueLiberty,
            /* ⛪ */ Church,
            /* 🕌 */ Mosque,
            /* 🕍 */ Synagogue,
            /* 🕋 */ Kaaba,
            /* ⛲ */ Fountain,
            /* ⛺ */ Tent,
            /* 🌁 */ Foggy,
            /* 🌃 */ NightStars,
            /* 🌄 */ SunriseOverMountains,
            /* 🌅 */ Sunrise,
            /* 🌆 */ CityscapeAtDusk,
            /* 🌇 */ Sunset,
            /* 🌉 */ BridgeAtNight,
            /* 🎠 */ CarouselHorse,
            /* 🎡 */ FerrisWheel,
            /* 🎢 */ RollerCoaster,
            /* 💈 */ BarberPole,
            /* 🎪 */ CircusTent,
            /* 🚂 */ Locomotive,
            /* 🚃 */ RailwayCar,
            /* 🚄 */ HighSpeedTrain,
            /* 🚅 */ BulletTrain,
            /* 🚆 */ Train,
            /* 🚇 */ Metro,
            /* 🚈 */ LightRail,
            /* 🚉 */ Station,
            /* 🚊 */ Tram,
            /* 🚝 */ Monorail,
            /* 🚞 */ MountainRailway,
            /* 🚋 */ TramCar,
            /* 🚌 */ Bus,
            /* 🚍 */ OncomingBus,
            /* 🚎 */ Trolleybus,
            /* 🚐 */ Minibus,
            /* 🚑 */ Ambulance,
            /* 🚒 */ FireEngine,
            /* 🚓 */ PoliceCar,
            /* 🚔 */ OncomingPoliceCar,
            /* 🚕 */ Taxi,
            /* 🚖 */ OncomingTaxi,
            /* 🚗 */ Automobile,
            /* 🚘 */ OncomingAutomobile,
            /* 🚙 */ SportUtilityVehicle,
            /* 🚚 */ DeliveryTruck,
            /* 🚛 */ ArticulatedLorry,
            /* 🚜 */ Tractor,
            /* 🛵 */ MotorScooter,
            /* 🚲 */ Bicycle,
            /* 🛴 */ KickScooter,
            /* 🛹 */ Skateboard,
            /* 🚏 */ BusStop,
            /* ⛽ */ FuelPump,
            /* 🚨 */ PoliceCarLight,
            /* 🚥 */ HorizontalTrafficLight,
            /* 🚦 */ VerticalTrafficLight,
            /* 🛑 */ StopSign,
            /* 🚧 */ Construction,
            /* ⚓ */ Anchor,
            /* ⛵ */ Sailboat,
            /* 🛶 */ Canoe,
            /* 🚤 */ Speedboat,
            /* 🚢 */ Ship,
            /* 🛫 */ AirplaneDeparture,
            /* 🛬 */ AirplaneArrival,
            /* 💺 */ Seat,
            /* 🚁 */ Helicopter,
            /* 🚟 */ SuspensionRailway,
            /* 🚠 */ MountainCableway,
            /* 🚡 */ AerialTramway,
            /* 🚀 */ Rocket,
            /* 🛸 */ FlyingSaucer,
            /* 🧳 */ Luggage,
            /* ⌛ */ HourglassDone,
            /* ⏳ */ HourglassNotDone,
            /* ⌚ */ Watch,
            /* ⏰ */ AlarmClock,
            /* 🕛 */ TwelveOclock,
            /* 🕧 */ TwelveThirty,
            /* 🕐 */ OneOclock,
            /* 🕜 */ OneThirty,
            /* 🕑 */ TwoOclock,
            /* 🕝 */ TwoThirty,
            /* 🕒 */ ThreeOclock,
            /* 🕞 */ ThreeThirty,
            /* 🕓 */ FourOclock,
            /* 🕟 */ FourThirty,
            /* 🕔 */ FiveOclock,
            /* 🕠 */ FiveThirty,
            /* 🕕 */ SixOclock,
            /* 🕡 */ SixThirty,
            /* 🕖 */ SevenOclock,
            /* 🕢 */ SevenThirty,
            /* 🕗 */ EightOclock,
            /* 🕣 */ EightThirty,
            /* 🕘 */ NineOclock,
            /* 🕤 */ NineThirty,
            /* 🕙 */ TenOclock,
            /* 🕥 */ TenThirty,
            /* 🕚 */ ElevenOclock,
            /* 🕦 */ ElevenThirty,
            /* 🌑 */ NewMoon,
            /* 🌒 */ WaxingCrescentMoon,
            /* 🌓 */ FirstQuarterMoon,
            /* 🌔 */ WaxingGibbousMoon,
            /* 🌕 */ FullMoon,
            /* 🌖 */ WaningGibbousMoon,
            /* 🌗 */ LastQuarterMoon,
            /* 🌘 */ WaningCrescentMoon,
            /* 🌙 */ CrescentMoon,
            /* 🌚 */ NewMoonFace,
            /* 🌛 */ FirstQuarterMoonFace,
            /* 🌜 */ LastQuarterMoonFace,
            /* 🌝 */ FullMoonFace,
            /* 🌞 */ SunFace,
            /* ⭐ */ Star,
            /* 🌟 */ GlowingStar,
            /* 🌠 */ ShootingStar,
            /* 🌌 */ MilkyWay,
            /* ⛅ */ SunBehindCloud,
            /* 🌀 */ Cyclone,
            /* 🌈 */ Rainbow,
            /* 🌂 */ ClosedUmbrella,
            /* ☔ */ UmbrellaRainDrops,
            /* ⚡ */ HighVoltage,
            /* ⛄ */ SnowmanSnow,
            /* 🔥 */ Fire,
            /* 💧 */ Droplet,
            /* 🌊 */ WaterWave,
            /* 🎃 */ JackOLantern,
            /* 🎄 */ ChristmasTree,
            /* 🎆 */ Fireworks,
            /* 🎇 */ Sparkler,
            /* 🧨 */ Firecracker,
            /* ✨ */ Sparkles,
            /* 🎈 */ Balloon,
            /* 🎉 */ PartyPopper,
            /* 🎊 */ ConfettiBall,
            /* 🎋 */ TanabataTree,
            /* 🎍 */ PineDecoration,
            /* 🎎 */ JapaneseDolls,
            /* 🎏 */ CarpStreamer,
            /* 🎐 */ WindChime,
            /* 🎑 */ MoonViewingCeremony,
            /* 🧧 */ RedEnvelope,
            /* 🎀 */ Ribbon,
            /* 🎁 */ WrappedGift,
            /* 🎫 */ Ticket,
            /* 🏆 */ Trophy,
            /* 🏅 */ SportsMedal,
            /* 🥇 */ FirstPlaceMedal,
            /* 🥈 */ SecondPlaceMedal,
            /* 🥉 */ ThirdPlaceMedal,
            /* ⚽ */ SoccerBall,
            /* ⚾ */ Baseball,
            /* 🥎 */ Softball,
            /* 🏀 */ Basketball,
            /* 🏐 */ Volleyball,
            /* 🏈 */ AmericanFootball,
            /* 🏉 */ RugbyFootball,
            /* 🎾 */ Tennis,
            /* 🥏 */ FlyingDisc,
            /* 🎳 */ Bowling,
            /* 🏏 */ CricketGame,
            /* 🏑 */ FieldHockey,
            /* 🏒 */ IceHockey,
            /* 🥍 */ Lacrosse,
            /* 🏓 */ PingPong,
            /* 🏸 */ Badminton,
            /* 🥊 */ BoxingGlove,
            /* 🥋 */ MartialArtsUniform,
            /* 🥅 */ GoalNet,
            /* ⛳ */ FlagHole,
            /* 🎣 */ FishingPole,
            /* 🎽 */ RunningShirt,
            /* 🎿 */ Skis,
            /* 🛷 */ Sled,
            /* 🥌 */ CurlingStone,
            /* 🎯 */ DirectHit,
            /* 🎱 */ Pool8Ball,
            /* 🔮 */ CrystalBall,
            /* 🧿 */ NazarAmulet,
            /* 🎮 */ VideoGame,
            /* 🎰 */ SlotMachine,
            /* 🎲 */ GameDie,
            /* 🧩 */ PuzzlePiece,
            /* 🧸 */ TeddyBear,
            /* 🃏 */ Joker,
            /* 🀄 */ MahjongRedDragon,
            /* 🎴 */ FlowerPlayingCards,
            /* 🎭 */ PerformingArts,
            /* 🎨 */ ArtistPalette,
            /* 🧵 */ Thread,
            /* 🧶 */ Yarn,
            /* 👓 */ Glasses,
            /* 🥽 */ Goggles,
            /* 🥼 */ LabCoat,
            /* 👔 */ Necktie,
            /* 👕 */ TShirt,
            /* 👖 */ Jeans,
            /* 🧣 */ Scarf,
            /* 🧤 */ Gloves,
            /* 🧥 */ Coat,
            /* 🧦 */ Socks,
            /* 👗 */ Dress,
            /* 👘 */ Kimono,
            /* 👙 */ Bikini,
            /* 👚 */ WomansClothes,
            /* 👛 */ Purse,
            /* 👜 */ Handbag,
            /* 👝 */ ClutchBag,
            /* 🎒 */ Backpack,
            /* 👞 */ MansShoe,
            /* 👟 */ RunningShoe,
            /* 🥾 */ HikingBoot,
            /* 🥿 */ FlatShoe,
            /* 👠 */ HighHeeledShoe,
            /* 👡 */ WomansSandal,
            /* 👢 */ WomansBoot,
            /* 👑 */ Crown,
            /* 👒 */ WomansHat,
            /* 🎩 */ TopHat,
            /* 🎓 */ GraduationCap,
            /* 🧢 */ BilledCap,
            /* 📿 */ PrayerBeads,
            /* 💄 */ Lipstick,
            /* 💍 */ Ring,
            /* 💎 */ GemStone,
            /* 🔇 */ MutedSpeaker,
            /* 🔈 */ SpeakerLowVolume,
            /* 🔉 */ SpeakerMediumVolume,
            /* 🔊 */ SpeakerHighVolume,
            /* 📢 */ Loudspeaker,
            /* 📣 */ Megaphone,
            /* 📯 */ PostalHorn,
            /* 🔔 */ Bell,
            /* 🔕 */ BellSlash,
            /* 🎼 */ MusicalScore,
            /* 🎵 */ MusicalNote,
            /* 🎶 */ MusicalNotes,
            /* 🎤 */ Microphone,
            /* 🎧 */ Headphone,
            /* 📻 */ Radio,
            /* 🎷 */ Saxophone,
            /* 🎸 */ Guitar,
            /* 🎹 */ MusicalKeyboard,
            /* 🎺 */ Trumpet,
            /* 🎻 */ Violin,
            /* 🥁 */ Drum,
            /* 📱 */ MobilePhone,
            /* 📲 */ MobilePhoneArrow,
            /* 📞 */ TelephoneReceiver,
            /* 📟 */ Pager,
            /* 📠 */ FaxMachine,
            /* 🔋 */ Battery,
            /* 🔌 */ ElectricPlug,
            /* 💻 */ LaptopComputer,
            /* 💽 */ ComputerDisk,
            /* 💾 */ FloppyDisk,
            /* 💿 */ OpticalDisk,
            /* 📀 */ Dvd,
            /* 🧮 */ Abacus,
            /* 🎥 */ MovieCamera,
            /* 🎬 */ ClapperBoard,
            /* 📺 */ Television,
            /* 📷 */ Camera,
            /* 📸 */ CameraFlash,
            /* 📹 */ VideoCamera,
            /* 📼 */ Videocassette,
            /* 🔍 */ MagnifyingGlassTiltedLeft,
            /* 🔎 */ MagnifyingGlassTiltedRight,
            /* 💡 */ LightBulb,
            /* 🔦 */ Flashlight,
            /* 🏮 */ RedPaperLantern,
            /* 📔 */ NotebookDecorativeCover,
            /* 📕 */ ClosedBook,
            /* 📖 */ OpenBook,
            /* 📗 */ GreenBook,
            /* 📘 */ BlueBook,
            /* 📙 */ OrangeBook,
            /* 📚 */ Books,
            /* 📓 */ Notebook,
            /* 📒 */ Ledger,
            /* 📃 */ PageCurl,
            /* 📜 */ Scroll,
            /* 📄 */ PageFacingUp,
            /* 📰 */ Newspaper,
            /* 📑 */ BookmarkTabs,
            /* 🔖 */ Bookmark,
            /* 💰 */ MoneyBag,
            /* 💴 */ YenBanknote,
            /* 💵 */ DollarBanknote,
            /* 💶 */ EuroBanknote,
            /* 💷 */ PoundBanknote,
            /* 💸 */ MoneyWings,
            /* 💳 */ CreditCard,
            /* 🧾 */ Receipt,
            /* 💹 */ ChartIncreasingYen,
            /* 💱 */ CurrencyExchange,
            /* 💲 */ HeavyDollarSign,
            /* 📧 */ EMail,
            /* 📨 */ IncomingEnvelope,
            /* 📩 */ EnvelopeArrow,
            /* 📤 */ OutboxTray,
            /* 📥 */ InboxTray,
            /* 📦 */ Package,
            /* 📫 */ ClosedMailboxRaisedFlag,
            /* 📪 */ ClosedMailboxLoweredFlag,
            /* 📬 */ OpenMailboxRaisedFlag,
            /* 📭 */ OpenMailboxLoweredFlag,
            /* 📮 */ Postbox,
            /* 📝 */ Memo,
            /* 💼 */ Briefcase,
            /* 📁 */ FileFolder,
            /* 📂 */ OpenFileFolder,
            /* 📅 */ Calendar,
            /* 📆 */ TearOffCalendar,
            /* 📇 */ CardIndex,
            /* 📈 */ ChartIncreasing,
            /* 📉 */ ChartDecreasing,
            /* 📊 */ BarChart,
            /* 📋 */ Clipboard,
            /* 📌 */ Pushpin,
            /* 📍 */ RoundPushpin,
            /* 📎 */ Paperclip,
            /* 📏 */ StraightRuler,
            /* 📐 */ TriangularRuler,
            /* 🔒 */ Locked,
            /* 🔓 */ Unlocked,
            /* 🔏 */ LockedPen,
            /* 🔐 */ LockedKey,
            /* 🔑 */ Key,
            /* 🔨 */ Hammer,
            /* 🔫 */ Pistol,
            /* 🏹 */ BowArrow,
            /* 🔧 */ Wrench,
            /* 🔩 */ NutBolt,
            /* 🔗 */ Link,
            /* 🧰 */ Toolbox,
            /* 🧲 */ Magnet,
            /* 🧪 */ TestTube,
            /* 🧫 */ PetriDish,
            /* 🧬 */ Dna,
            /* 🔬 */ Microscope,
            /* 🔭 */ Telescope,
            /* 📡 */ SatelliteAntenna,
            /* 💉 */ Syringe,
            /* 💊 */ Pill,
            /* 🚪 */ Door,
            /* 🚽 */ Toilet,
            /* 🚿 */ Shower,
            /* 🛁 */ Bathtub,
            /* 🧴 */ LotionBottle,
            /* 🧷 */ SafetyPin,
            /* 🧹 */ Broom,
            /* 🧺 */ Basket,
            /* 🧻 */ RollPaper,
            /* 🧼 */ Soap,
            /* 🧽 */ Sponge,
            /* 🧯 */ FireExtinguisher,
            /* 🛒 */ ShoppingCart,
            /* 🚬 */ Cigarette,
            /* 🗿 */ Moai,
            /* 🏧 */ AtmSign,
            /* 🚮 */ LitterBinSign,
            /* 🚰 */ PotableWater,
            /* ♿ */ WheelchairSymbol,
            /* 🚹 */ MensRoom,
            /* 🚺 */ WomensRoom,
            /* 🚻 */ Restroom,
            /* 🚼 */ BabySymbol,
            /* 🚾 */ WaterCloset,
            /* 🛂 */ PassportControl,
            /* 🛃 */ Customs,
            /* 🛄 */ BaggageClaim,
            /* 🛅 */ LeftLuggage,
            /* 🚸 */ ChildrenCrossing,
            /* ⛔ */ NoEntry,
            /* 🚫 */ Prohibited,
            /* 🚳 */ NoBicycles,
            /* 🚭 */ NoSmoking,
            /* 🚯 */ NoLittering,
            /* 🚱 */ NonPotableWater,
            /* 🚷 */ NoPedestrians,
            /* 📵 */ NoMobilePhones,
            /* 🔞 */ NoOneUnderEighteen,
            /* 🔃 */ ClockwiseVerticalArrows,
            /* 🔄 */ CounterclockwiseArrowsButton,
            /* 🔙 */ BackArrow,
            /* 🔚 */ EndArrow,
            /* 🔛 */ OnArrow,
            /* 🔜 */ SoonArrow,
            /* 🔝 */ TopArrow,
            /* 🛐 */ PlaceWorship,
            /* 🕎 */ Menorah,
            /* 🔯 */ DottedSixPointedStar,
            /* ♈ */ Aries,
            /* ♉ */ Taurus,
            /* ♊ */ Gemini,
            /* ♋ */ Cancer,
            /* ♌ */ Leo,
            /* ♍ */ Virgo,
            /* ♎ */ Libra,
            /* ♏ */ Scorpio,
            /* ♐ */ Sagittarius,
            /* ♑ */ Capricorn,
            /* ♒ */ Aquarius,
            /* ♓ */ Pisces,
            /* ⛎ */ Ophiuchus,
            /* 🔀 */ ShuffleTracksButton,
            /* 🔁 */ RepeatButton,
            /* 🔂 */ RepeatSingleButton,
            /* ⏩ */ FastForwardButton,
            /* ⏪ */ FastReverseButton,
            /* 🔼 */ UpwardsButton,
            /* ⏫ */ FastUpButton,
            /* 🔽 */ DownwardsButton,
            /* ⏬ */ FastDownButton,
            /* 🎦 */ Cinema,
            /* 🔅 */ DimButton,
            /* 🔆 */ BrightButton,
            /* 📶 */ AntennaBars,
            /* 📳 */ VibrationMode,
            /* 📴 */ MobilePhoneOff,
            /* 🔱 */ TridentEmblem,
            /* 📛 */ NameBadge,
            /* 🔰 */ JapaneseSymbolForBeginner,
            /* ⭕ */ HollowRedCircle,
            /* ✅ */ CheckMarkButton,
            /* ❌ */ CrossMark,
            /* ❎ */ CrossMarkButton,
            /* ➕ */ PlusSign,
            /* ➖ */ MinusSign,
            /* ➗ */ DivisionSign,
            /* ➰ */ CurlyLoop,
            /* ➿ */ DoubleCurlyLoop,
            /* ❓ */ QuestionMark,
            /* ❔ */ WhiteQuestionMark,
            /* ❕ */ WhiteExclamationMark,
            /* ❗ */ ExclamationMark,
            /* 🔟 */ Keycap10,
            /* 🔠 */ InputLatinUppercase,
            /* 🔡 */ InputLatinLowercase,
            /* 🔢 */ InputNumbers,
            /* 🔣 */ InputSymbols,
            /* 🔤 */ InputLatinLetters,
            /* 🆎 */ AbButtonBloodType,
            /* 🆑 */ ClButton,
            /* 🆒 */ CoolButton,
            /* 🆓 */ FreeButton,
            /* 🆔 */ IdButton,
            /* 🆕 */ NewButton,
            /* 🆖 */ NgButton,
            /* 🆗 */ OkButton,
            /* 🆘 */ SosButton,
            /* 🆙 */ UpButton,
            /* 🆚 */ VsButton,
            /* 🈁 */ JapaneseHereButton,
            /* 🈶 */ JapaneseNotFreeChargeButton,
            /* 🈯 */ JapaneseReservedButton,
            /* 🉐 */ JapaneseBargainButton,
            /* 🈹 */ JapaneseDiscountButton,
            /* 🈚 */ JapaneseFreeChargeButton,
            /* 🈲 */ JapaneseProhibitedButton,
            /* 🉑 */ JapaneseAcceptableButton,
            /* 🈸 */ JapaneseApplicationButton,
            /* 🈴 */ JapanesePassingGradeButton,
            /* 🈳 */ JapaneseVacancyButton,
            /* 🈺 */ JapaneseOpenForBusinessButton,
            /* 🈵 */ JapaneseNoVacancyButton,
            /* 🔴 */ RedCircle,
            /* 🔵 */ BlueCircle,
            /* ⚫ */ BlackCircle,
            /* ⚪ */ WhiteCircle,
            /* ⬛ */ BlackLargeSquare,
            /* ⬜ */ WhiteLargeSquare,
            /* ◾ */ BlackMediumSmallSquare,
            /* ◽ */ WhiteMediumSmallSquare,
            /* 🔶 */ LargeOrangeDiamond,
            /* 🔷 */ LargeBlueDiamond,
            /* 🔸 */ SmallOrangeDiamond,
            /* 🔹 */ SmallBlueDiamond,
            /* 🔺 */ RedTrianglePointedUp,
            /* 🔻 */ RedTrianglePointedDown,
            /* 💠 */ DiamondADot,
            /* 🔘 */ RadioButton,
            /* 🔳 */ WhiteSquareButton,
            /* 🔲 */ BlackSquareButton,
            /* 🏁 */ ChequeredFlag,
            /* 🚩 */ TriangularFlag,
            /* 🎌 */ CrossedFlags,
            /* 🏴 */ BlackFlag,
        };
    }
}
