namespace Base36Library.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Encoding
    {
        [TestMethod]
        public void Negative()
        {
            Assert.AreEqual("-AAA", Base36.Encode(-13330L));
            Assert.AreEqual("-NEGATIVE", Base36.Encode(-1833836359370));
        }

        [TestMethod]
        public void MultiplesOf10()
        {
            Assert.AreEqual("A", Base36.Encode(10L));
            Assert.AreEqual("2S", Base36.Encode(100L));
            Assert.AreEqual("RS", Base36.Encode(1000L));
            Assert.AreEqual("7PS", Base36.Encode(10000L));
            Assert.AreEqual("255S", Base36.Encode(100000L));
            Assert.AreEqual("LFLS", Base36.Encode(1000000L));
            Assert.AreEqual("5YC1S", Base36.Encode(10000000L));
            Assert.AreEqual("1NJCHS", Base36.Encode(100000000L));
            Assert.AreEqual("GJDGXS", Base36.Encode(1000000000L));
            Assert.AreEqual("4LDQPDS", Base36.Encode(10000000000L));
            Assert.AreEqual("19XTF1TS", Base36.Encode(100000000000L));
            Assert.AreEqual("CRE66I9S", Base36.Encode(1000000000000L));
            Assert.AreEqual("3JLXPT2PS", Base36.Encode(10000000000000L));
            Assert.AreEqual("ZG3D62R5S", Base36.Encode(100000000000000L));
            Assert.AreEqual("9UGXNORJLS", Base36.Encode(1000000000000000L));
            Assert.AreEqual("2QGPCKVNG1S", Base36.Encode(10000000000000000L));
            Assert.AreEqual("RCN1HSSIGHS", Base36.Encode(100000000000000000L));
            Assert.AreEqual("7LIEEXZX4KXS", Base36.Encode(1000000000000000000L));
        }

        [TestMethod]
        public void MultiplesOf36()
        {
            Assert.AreEqual("10", Base36.Encode(36L));
            Assert.AreEqual("100", Base36.Encode(1296L));
            Assert.AreEqual("1000", Base36.Encode(46656L));
            Assert.AreEqual("10000", Base36.Encode(1679616L));
            Assert.AreEqual("100000", Base36.Encode(60466176L));
            Assert.AreEqual("1000000", Base36.Encode(2176782336L));
            Assert.AreEqual("10000000", Base36.Encode(78364164096L));
            Assert.AreEqual("100000000", Base36.Encode(2821109907456L));
            Assert.AreEqual("1000000000", Base36.Encode(101559956668416L));
            Assert.AreEqual("10000000000", Base36.Encode(3656158440062976L));
            Assert.AreEqual("100000000000", Base36.Encode(131621703842267136L));
        }

        [TestMethod]
        public void LongMinValue()
        {
            Assert.AreEqual("-1Y2P0IJ32E8E8", Base36.Encode(long.MinValue));
        }

        [TestMethod]
        public void LongMaxValue()
        {
            Assert.AreEqual("1Y2P0IJ32E8E7", Base36.Encode(long.MaxValue));
        }

        [TestMethod]
        public void SingleDigits()
        {
            #region 0 to 35

            Assert.AreEqual("0", Base36.Encode(0L));
            Assert.AreEqual("1", Base36.Encode(1L));
            Assert.AreEqual("2", Base36.Encode(2L));
            Assert.AreEqual("3", Base36.Encode(3L));
            Assert.AreEqual("4", Base36.Encode(4L));
            Assert.AreEqual("5", Base36.Encode(5L));
            Assert.AreEqual("6", Base36.Encode(6L));
            Assert.AreEqual("7", Base36.Encode(7L));
            Assert.AreEqual("8", Base36.Encode(8L));
            Assert.AreEqual("9", Base36.Encode(9L));
            Assert.AreEqual("A", Base36.Encode(10L));
            Assert.AreEqual("B", Base36.Encode(11L));
            Assert.AreEqual("C", Base36.Encode(12L));
            Assert.AreEqual("D", Base36.Encode(13L));
            Assert.AreEqual("E", Base36.Encode(14L));
            Assert.AreEqual("F", Base36.Encode(15L));
            Assert.AreEqual("G", Base36.Encode(16L));
            Assert.AreEqual("H", Base36.Encode(17L));
            Assert.AreEqual("I", Base36.Encode(18L));
            Assert.AreEqual("J", Base36.Encode(19L));
            Assert.AreEqual("K", Base36.Encode(20L));
            Assert.AreEqual("L", Base36.Encode(21L));
            Assert.AreEqual("M", Base36.Encode(22L));
            Assert.AreEqual("N", Base36.Encode(23L));
            Assert.AreEqual("O", Base36.Encode(24L));
            Assert.AreEqual("P", Base36.Encode(25L));
            Assert.AreEqual("Q", Base36.Encode(26L));
            Assert.AreEqual("R", Base36.Encode(27L));
            Assert.AreEqual("S", Base36.Encode(28L));
            Assert.AreEqual("T", Base36.Encode(29L));
            Assert.AreEqual("U", Base36.Encode(30L));
            Assert.AreEqual("V", Base36.Encode(31L));
            Assert.AreEqual("W", Base36.Encode(32L));
            Assert.AreEqual("X", Base36.Encode(33L));
            Assert.AreEqual("Y", Base36.Encode(34L));
            Assert.AreEqual("Z", Base36.Encode(35L));

            #endregion
        }

        [TestMethod]
        public void DoubleDigits()
        {
            #region 10 to 1Z

            Assert.AreEqual("10", Base36.Encode(36L));
            Assert.AreEqual("11", Base36.Encode(37L));
            Assert.AreEqual("12", Base36.Encode(38L));
            Assert.AreEqual("13", Base36.Encode(39L));
            Assert.AreEqual("14", Base36.Encode(40L));
            Assert.AreEqual("15", Base36.Encode(41L));
            Assert.AreEqual("16", Base36.Encode(42L));
            Assert.AreEqual("17", Base36.Encode(43L));
            Assert.AreEqual("18", Base36.Encode(44L));
            Assert.AreEqual("19", Base36.Encode(45L));
            Assert.AreEqual("1A", Base36.Encode(46L));
            Assert.AreEqual("1B", Base36.Encode(47L));
            Assert.AreEqual("1C", Base36.Encode(48L));
            Assert.AreEqual("1D", Base36.Encode(49L));
            Assert.AreEqual("1E", Base36.Encode(50L));
            Assert.AreEqual("1F", Base36.Encode(51L));
            Assert.AreEqual("1G", Base36.Encode(52L));
            Assert.AreEqual("1H", Base36.Encode(53L));
            Assert.AreEqual("1I", Base36.Encode(54L));
            Assert.AreEqual("1J", Base36.Encode(55L));
            Assert.AreEqual("1K", Base36.Encode(56L));
            Assert.AreEqual("1L", Base36.Encode(57L));
            Assert.AreEqual("1M", Base36.Encode(58L));
            Assert.AreEqual("1N", Base36.Encode(59L));
            Assert.AreEqual("1O", Base36.Encode(60L));
            Assert.AreEqual("1P", Base36.Encode(61L));
            Assert.AreEqual("1Q", Base36.Encode(62L));
            Assert.AreEqual("1R", Base36.Encode(63L));
            Assert.AreEqual("1S", Base36.Encode(64L));
            Assert.AreEqual("1T", Base36.Encode(65L));
            Assert.AreEqual("1U", Base36.Encode(66L));
            Assert.AreEqual("1V", Base36.Encode(67L));
            Assert.AreEqual("1W", Base36.Encode(68L));
            Assert.AreEqual("1X", Base36.Encode(69L));
            Assert.AreEqual("1Y", Base36.Encode(70L));
            Assert.AreEqual("1Z", Base36.Encode(71L));

            #endregion

            #region 20 to 2Z

            Assert.AreEqual("20", Base36.Encode(72L));
            Assert.AreEqual("21", Base36.Encode(73L));
            Assert.AreEqual("22", Base36.Encode(74L));
            Assert.AreEqual("23", Base36.Encode(75L));
            Assert.AreEqual("24", Base36.Encode(76L));
            Assert.AreEqual("25", Base36.Encode(77L));
            Assert.AreEqual("26", Base36.Encode(78L));
            Assert.AreEqual("27", Base36.Encode(79L));
            Assert.AreEqual("28", Base36.Encode(80L));
            Assert.AreEqual("29", Base36.Encode(81L));
            Assert.AreEqual("2A", Base36.Encode(82L));
            Assert.AreEqual("2B", Base36.Encode(83L));
            Assert.AreEqual("2C", Base36.Encode(84L));
            Assert.AreEqual("2D", Base36.Encode(85L));
            Assert.AreEqual("2E", Base36.Encode(86L));
            Assert.AreEqual("2F", Base36.Encode(87L));
            Assert.AreEqual("2G", Base36.Encode(88L));
            Assert.AreEqual("2H", Base36.Encode(89L));
            Assert.AreEqual("2I", Base36.Encode(90L));
            Assert.AreEqual("2J", Base36.Encode(91L));
            Assert.AreEqual("2K", Base36.Encode(92L));
            Assert.AreEqual("2L", Base36.Encode(93L));
            Assert.AreEqual("2M", Base36.Encode(94L));
            Assert.AreEqual("2N", Base36.Encode(95L));
            Assert.AreEqual("2O", Base36.Encode(96L));
            Assert.AreEqual("2P", Base36.Encode(97L));
            Assert.AreEqual("2Q", Base36.Encode(98L));
            Assert.AreEqual("2R", Base36.Encode(99L));
            Assert.AreEqual("2S", Base36.Encode(100L));
            Assert.AreEqual("2T", Base36.Encode(101L));
            Assert.AreEqual("2U", Base36.Encode(102L));
            Assert.AreEqual("2V", Base36.Encode(103L));
            Assert.AreEqual("2W", Base36.Encode(104L));
            Assert.AreEqual("2X", Base36.Encode(105L));
            Assert.AreEqual("2Y", Base36.Encode(106L));
            Assert.AreEqual("2Z", Base36.Encode(107L));

            #endregion

            #region 30 to 3Z

            Assert.AreEqual("30", Base36.Encode(108L));
            Assert.AreEqual("31", Base36.Encode(109L));
            Assert.AreEqual("32", Base36.Encode(110L));
            Assert.AreEqual("33", Base36.Encode(111L));
            Assert.AreEqual("34", Base36.Encode(112L));
            Assert.AreEqual("35", Base36.Encode(113L));
            Assert.AreEqual("36", Base36.Encode(114L));
            Assert.AreEqual("37", Base36.Encode(115L));
            Assert.AreEqual("38", Base36.Encode(116L));
            Assert.AreEqual("39", Base36.Encode(117L));
            Assert.AreEqual("3A", Base36.Encode(118L));
            Assert.AreEqual("3B", Base36.Encode(119L));
            Assert.AreEqual("3C", Base36.Encode(120L));
            Assert.AreEqual("3D", Base36.Encode(121L));
            Assert.AreEqual("3E", Base36.Encode(122L));
            Assert.AreEqual("3F", Base36.Encode(123L));
            Assert.AreEqual("3G", Base36.Encode(124L));
            Assert.AreEqual("3H", Base36.Encode(125L));
            Assert.AreEqual("3I", Base36.Encode(126L));
            Assert.AreEqual("3J", Base36.Encode(127L));
            Assert.AreEqual("3K", Base36.Encode(128L));
            Assert.AreEqual("3L", Base36.Encode(129L));
            Assert.AreEqual("3M", Base36.Encode(130L));
            Assert.AreEqual("3N", Base36.Encode(131L));
            Assert.AreEqual("3O", Base36.Encode(132L));
            Assert.AreEqual("3P", Base36.Encode(133L));
            Assert.AreEqual("3Q", Base36.Encode(134L));
            Assert.AreEqual("3R", Base36.Encode(135L));
            Assert.AreEqual("3S", Base36.Encode(136L));
            Assert.AreEqual("3T", Base36.Encode(137L));
            Assert.AreEqual("3U", Base36.Encode(138L));
            Assert.AreEqual("3V", Base36.Encode(139L));
            Assert.AreEqual("3W", Base36.Encode(140L));
            Assert.AreEqual("3X", Base36.Encode(141L));
            Assert.AreEqual("3Y", Base36.Encode(142L));
            Assert.AreEqual("3Z", Base36.Encode(143L));

            #endregion

            #region 40 to 4Z

            Assert.AreEqual("40", Base36.Encode(144L));
            Assert.AreEqual("41", Base36.Encode(145L));
            Assert.AreEqual("42", Base36.Encode(146L));
            Assert.AreEqual("43", Base36.Encode(147L));
            Assert.AreEqual("44", Base36.Encode(148L));
            Assert.AreEqual("45", Base36.Encode(149L));
            Assert.AreEqual("46", Base36.Encode(150L));
            Assert.AreEqual("47", Base36.Encode(151L));
            Assert.AreEqual("48", Base36.Encode(152L));
            Assert.AreEqual("49", Base36.Encode(153L));
            Assert.AreEqual("4A", Base36.Encode(154L));
            Assert.AreEqual("4B", Base36.Encode(155L));
            Assert.AreEqual("4C", Base36.Encode(156L));
            Assert.AreEqual("4D", Base36.Encode(157L));
            Assert.AreEqual("4E", Base36.Encode(158L));
            Assert.AreEqual("4F", Base36.Encode(159L));
            Assert.AreEqual("4G", Base36.Encode(160L));
            Assert.AreEqual("4H", Base36.Encode(161L));
            Assert.AreEqual("4I", Base36.Encode(162L));
            Assert.AreEqual("4J", Base36.Encode(163L));
            Assert.AreEqual("4K", Base36.Encode(164L));
            Assert.AreEqual("4L", Base36.Encode(165L));
            Assert.AreEqual("4M", Base36.Encode(166L));
            Assert.AreEqual("4N", Base36.Encode(167L));
            Assert.AreEqual("4O", Base36.Encode(168L));
            Assert.AreEqual("4P", Base36.Encode(169L));
            Assert.AreEqual("4Q", Base36.Encode(170L));
            Assert.AreEqual("4R", Base36.Encode(171L));
            Assert.AreEqual("4S", Base36.Encode(172L));
            Assert.AreEqual("4T", Base36.Encode(173L));
            Assert.AreEqual("4U", Base36.Encode(174L));
            Assert.AreEqual("4V", Base36.Encode(175L));
            Assert.AreEqual("4W", Base36.Encode(176L));
            Assert.AreEqual("4X", Base36.Encode(177L));
            Assert.AreEqual("4Y", Base36.Encode(178L));
            Assert.AreEqual("4Z", Base36.Encode(179L));

            #endregion

            #region 50 to 5Z

            Assert.AreEqual("50", Base36.Encode(180L));
            Assert.AreEqual("51", Base36.Encode(181L));
            Assert.AreEqual("52", Base36.Encode(182L));
            Assert.AreEqual("53", Base36.Encode(183L));
            Assert.AreEqual("54", Base36.Encode(184L));
            Assert.AreEqual("55", Base36.Encode(185L));
            Assert.AreEqual("56", Base36.Encode(186L));
            Assert.AreEqual("57", Base36.Encode(187L));
            Assert.AreEqual("58", Base36.Encode(188L));
            Assert.AreEqual("59", Base36.Encode(189L));
            Assert.AreEqual("5A", Base36.Encode(190L));
            Assert.AreEqual("5B", Base36.Encode(191L));
            Assert.AreEqual("5C", Base36.Encode(192L));
            Assert.AreEqual("5D", Base36.Encode(193L));
            Assert.AreEqual("5E", Base36.Encode(194L));
            Assert.AreEqual("5F", Base36.Encode(195L));
            Assert.AreEqual("5G", Base36.Encode(196L));
            Assert.AreEqual("5H", Base36.Encode(197L));
            Assert.AreEqual("5I", Base36.Encode(198L));
            Assert.AreEqual("5J", Base36.Encode(199L));
            Assert.AreEqual("5K", Base36.Encode(200L));
            Assert.AreEqual("5L", Base36.Encode(201L));
            Assert.AreEqual("5M", Base36.Encode(202L));
            Assert.AreEqual("5N", Base36.Encode(203L));
            Assert.AreEqual("5O", Base36.Encode(204L));
            Assert.AreEqual("5P", Base36.Encode(205L));
            Assert.AreEqual("5Q", Base36.Encode(206L));
            Assert.AreEqual("5R", Base36.Encode(207L));
            Assert.AreEqual("5S", Base36.Encode(208L));
            Assert.AreEqual("5T", Base36.Encode(209L));
            Assert.AreEqual("5U", Base36.Encode(210L));
            Assert.AreEqual("5V", Base36.Encode(211L));
            Assert.AreEqual("5W", Base36.Encode(212L));
            Assert.AreEqual("5X", Base36.Encode(213L));
            Assert.AreEqual("5Y", Base36.Encode(214L));
            Assert.AreEqual("5Z", Base36.Encode(215L));

            #endregion

            #region 60 to 6Z

            Assert.AreEqual("60", Base36.Encode(216L));
            Assert.AreEqual("61", Base36.Encode(217L));
            Assert.AreEqual("62", Base36.Encode(218L));
            Assert.AreEqual("63", Base36.Encode(219L));
            Assert.AreEqual("64", Base36.Encode(220L));
            Assert.AreEqual("65", Base36.Encode(221L));
            Assert.AreEqual("66", Base36.Encode(222L));
            Assert.AreEqual("67", Base36.Encode(223L));
            Assert.AreEqual("68", Base36.Encode(224L));
            Assert.AreEqual("69", Base36.Encode(225L));
            Assert.AreEqual("6A", Base36.Encode(226L));
            Assert.AreEqual("6B", Base36.Encode(227L));
            Assert.AreEqual("6C", Base36.Encode(228L));
            Assert.AreEqual("6D", Base36.Encode(229L));
            Assert.AreEqual("6E", Base36.Encode(230L));
            Assert.AreEqual("6F", Base36.Encode(231L));
            Assert.AreEqual("6G", Base36.Encode(232L));
            Assert.AreEqual("6H", Base36.Encode(233L));
            Assert.AreEqual("6I", Base36.Encode(234L));
            Assert.AreEqual("6J", Base36.Encode(235L));
            Assert.AreEqual("6K", Base36.Encode(236L));
            Assert.AreEqual("6L", Base36.Encode(237L));
            Assert.AreEqual("6M", Base36.Encode(238L));
            Assert.AreEqual("6N", Base36.Encode(239L));
            Assert.AreEqual("6O", Base36.Encode(240L));
            Assert.AreEqual("6P", Base36.Encode(241L));
            Assert.AreEqual("6Q", Base36.Encode(242L));
            Assert.AreEqual("6R", Base36.Encode(243L));
            Assert.AreEqual("6S", Base36.Encode(244L));
            Assert.AreEqual("6T", Base36.Encode(245L));
            Assert.AreEqual("6U", Base36.Encode(246L));
            Assert.AreEqual("6V", Base36.Encode(247L));
            Assert.AreEqual("6W", Base36.Encode(248L));
            Assert.AreEqual("6X", Base36.Encode(249L));
            Assert.AreEqual("6Y", Base36.Encode(250L));
            Assert.AreEqual("6Z", Base36.Encode(251L));

            #endregion

            #region 70 to 7Z

            Assert.AreEqual("70", Base36.Encode(252L));
            Assert.AreEqual("71", Base36.Encode(253L));
            Assert.AreEqual("72", Base36.Encode(254L));
            Assert.AreEqual("73", Base36.Encode(255L));
            Assert.AreEqual("74", Base36.Encode(256L));
            Assert.AreEqual("75", Base36.Encode(257L));
            Assert.AreEqual("76", Base36.Encode(258L));
            Assert.AreEqual("77", Base36.Encode(259L));
            Assert.AreEqual("78", Base36.Encode(260L));
            Assert.AreEqual("79", Base36.Encode(261L));
            Assert.AreEqual("7A", Base36.Encode(262L));
            Assert.AreEqual("7B", Base36.Encode(263L));
            Assert.AreEqual("7C", Base36.Encode(264L));
            Assert.AreEqual("7D", Base36.Encode(265L));
            Assert.AreEqual("7E", Base36.Encode(266L));
            Assert.AreEqual("7F", Base36.Encode(267L));
            Assert.AreEqual("7G", Base36.Encode(268L));
            Assert.AreEqual("7H", Base36.Encode(269L));
            Assert.AreEqual("7I", Base36.Encode(270L));
            Assert.AreEqual("7J", Base36.Encode(271L));
            Assert.AreEqual("7K", Base36.Encode(272L));
            Assert.AreEqual("7L", Base36.Encode(273L));
            Assert.AreEqual("7M", Base36.Encode(274L));
            Assert.AreEqual("7N", Base36.Encode(275L));
            Assert.AreEqual("7O", Base36.Encode(276L));
            Assert.AreEqual("7P", Base36.Encode(277L));
            Assert.AreEqual("7Q", Base36.Encode(278L));
            Assert.AreEqual("7R", Base36.Encode(279L));
            Assert.AreEqual("7S", Base36.Encode(280L));
            Assert.AreEqual("7T", Base36.Encode(281L));
            Assert.AreEqual("7U", Base36.Encode(282L));
            Assert.AreEqual("7V", Base36.Encode(283L));
            Assert.AreEqual("7W", Base36.Encode(284L));
            Assert.AreEqual("7X", Base36.Encode(285L));
            Assert.AreEqual("7Y", Base36.Encode(286L));
            Assert.AreEqual("7Z", Base36.Encode(287L));

            #endregion

            #region 80 to 8Z

            Assert.AreEqual("80", Base36.Encode(288L));
            Assert.AreEqual("81", Base36.Encode(289L));
            Assert.AreEqual("82", Base36.Encode(290L));
            Assert.AreEqual("83", Base36.Encode(291L));
            Assert.AreEqual("84", Base36.Encode(292L));
            Assert.AreEqual("85", Base36.Encode(293L));
            Assert.AreEqual("86", Base36.Encode(294L));
            Assert.AreEqual("87", Base36.Encode(295L));
            Assert.AreEqual("88", Base36.Encode(296L));
            Assert.AreEqual("89", Base36.Encode(297L));
            Assert.AreEqual("8A", Base36.Encode(298L));
            Assert.AreEqual("8B", Base36.Encode(299L));
            Assert.AreEqual("8C", Base36.Encode(300L));
            Assert.AreEqual("8D", Base36.Encode(301L));
            Assert.AreEqual("8E", Base36.Encode(302L));
            Assert.AreEqual("8F", Base36.Encode(303L));
            Assert.AreEqual("8G", Base36.Encode(304L));
            Assert.AreEqual("8H", Base36.Encode(305L));
            Assert.AreEqual("8I", Base36.Encode(306L));
            Assert.AreEqual("8J", Base36.Encode(307L));
            Assert.AreEqual("8K", Base36.Encode(308L));
            Assert.AreEqual("8L", Base36.Encode(309L));
            Assert.AreEqual("8M", Base36.Encode(310L));
            Assert.AreEqual("8N", Base36.Encode(311L));
            Assert.AreEqual("8O", Base36.Encode(312L));
            Assert.AreEqual("8P", Base36.Encode(313L));
            Assert.AreEqual("8Q", Base36.Encode(314L));
            Assert.AreEqual("8R", Base36.Encode(315L));
            Assert.AreEqual("8S", Base36.Encode(316L));
            Assert.AreEqual("8T", Base36.Encode(317L));
            Assert.AreEqual("8U", Base36.Encode(318L));
            Assert.AreEqual("8V", Base36.Encode(319L));
            Assert.AreEqual("8W", Base36.Encode(320L));
            Assert.AreEqual("8X", Base36.Encode(321L));
            Assert.AreEqual("8Y", Base36.Encode(322L));
            Assert.AreEqual("8Z", Base36.Encode(323L));

            #endregion

            #region 90 to 9Z

            Assert.AreEqual("90", Base36.Encode(324L));
            Assert.AreEqual("91", Base36.Encode(325L));
            Assert.AreEqual("92", Base36.Encode(326L));
            Assert.AreEqual("93", Base36.Encode(327L));
            Assert.AreEqual("94", Base36.Encode(328L));
            Assert.AreEqual("95", Base36.Encode(329L));
            Assert.AreEqual("96", Base36.Encode(330L));
            Assert.AreEqual("97", Base36.Encode(331L));
            Assert.AreEqual("98", Base36.Encode(332L));
            Assert.AreEqual("99", Base36.Encode(333L));
            Assert.AreEqual("9A", Base36.Encode(334L));
            Assert.AreEqual("9B", Base36.Encode(335L));
            Assert.AreEqual("9C", Base36.Encode(336L));
            Assert.AreEqual("9D", Base36.Encode(337L));
            Assert.AreEqual("9E", Base36.Encode(338L));
            Assert.AreEqual("9F", Base36.Encode(339L));
            Assert.AreEqual("9G", Base36.Encode(340L));
            Assert.AreEqual("9H", Base36.Encode(341L));
            Assert.AreEqual("9I", Base36.Encode(342L));
            Assert.AreEqual("9J", Base36.Encode(343L));
            Assert.AreEqual("9K", Base36.Encode(344L));
            Assert.AreEqual("9L", Base36.Encode(345L));
            Assert.AreEqual("9M", Base36.Encode(346L));
            Assert.AreEqual("9N", Base36.Encode(347L));
            Assert.AreEqual("9O", Base36.Encode(348L));
            Assert.AreEqual("9P", Base36.Encode(349L));
            Assert.AreEqual("9Q", Base36.Encode(350L));
            Assert.AreEqual("9R", Base36.Encode(351L));
            Assert.AreEqual("9S", Base36.Encode(352L));
            Assert.AreEqual("9T", Base36.Encode(353L));
            Assert.AreEqual("9U", Base36.Encode(354L));
            Assert.AreEqual("9V", Base36.Encode(355L));
            Assert.AreEqual("9W", Base36.Encode(356L));
            Assert.AreEqual("9X", Base36.Encode(357L));
            Assert.AreEqual("9Y", Base36.Encode(358L));
            Assert.AreEqual("9Z", Base36.Encode(359L));

            #endregion

            #region A0 to AZ

            Assert.AreEqual("A0", Base36.Encode(360L));
            Assert.AreEqual("A1", Base36.Encode(361L));
            Assert.AreEqual("A2", Base36.Encode(362L));
            Assert.AreEqual("A3", Base36.Encode(363L));
            Assert.AreEqual("A4", Base36.Encode(364L));
            Assert.AreEqual("A5", Base36.Encode(365L));
            Assert.AreEqual("A6", Base36.Encode(366L));
            Assert.AreEqual("A7", Base36.Encode(367L));
            Assert.AreEqual("A8", Base36.Encode(368L));
            Assert.AreEqual("A9", Base36.Encode(369L));
            Assert.AreEqual("AA", Base36.Encode(370L));
            Assert.AreEqual("AB", Base36.Encode(371L));
            Assert.AreEqual("AC", Base36.Encode(372L));
            Assert.AreEqual("AD", Base36.Encode(373L));
            Assert.AreEqual("AE", Base36.Encode(374L));
            Assert.AreEqual("AF", Base36.Encode(375L));
            Assert.AreEqual("AG", Base36.Encode(376L));
            Assert.AreEqual("AH", Base36.Encode(377L));
            Assert.AreEqual("AI", Base36.Encode(378L));
            Assert.AreEqual("AJ", Base36.Encode(379L));
            Assert.AreEqual("AK", Base36.Encode(380L));
            Assert.AreEqual("AL", Base36.Encode(381L));
            Assert.AreEqual("AM", Base36.Encode(382L));
            Assert.AreEqual("AN", Base36.Encode(383L));
            Assert.AreEqual("AO", Base36.Encode(384L));
            Assert.AreEqual("AP", Base36.Encode(385L));
            Assert.AreEqual("AQ", Base36.Encode(386L));
            Assert.AreEqual("AR", Base36.Encode(387L));
            Assert.AreEqual("AS", Base36.Encode(388L));
            Assert.AreEqual("AT", Base36.Encode(389L));
            Assert.AreEqual("AU", Base36.Encode(390L));
            Assert.AreEqual("AV", Base36.Encode(391L));
            Assert.AreEqual("AW", Base36.Encode(392L));
            Assert.AreEqual("AX", Base36.Encode(393L));
            Assert.AreEqual("AY", Base36.Encode(394L));
            Assert.AreEqual("AZ", Base36.Encode(395L));

            #endregion

            #region B0 to BZ

            Assert.AreEqual("B0", Base36.Encode(396L));
            Assert.AreEqual("B1", Base36.Encode(397L));
            Assert.AreEqual("B2", Base36.Encode(398L));
            Assert.AreEqual("B3", Base36.Encode(399L));
            Assert.AreEqual("B4", Base36.Encode(400L));
            Assert.AreEqual("B5", Base36.Encode(401L));
            Assert.AreEqual("B6", Base36.Encode(402L));
            Assert.AreEqual("B7", Base36.Encode(403L));
            Assert.AreEqual("B8", Base36.Encode(404L));
            Assert.AreEqual("B9", Base36.Encode(405L));
            Assert.AreEqual("BA", Base36.Encode(406L));
            Assert.AreEqual("BB", Base36.Encode(407L));
            Assert.AreEqual("BC", Base36.Encode(408L));
            Assert.AreEqual("BD", Base36.Encode(409L));
            Assert.AreEqual("BE", Base36.Encode(410L));
            Assert.AreEqual("BF", Base36.Encode(411L));
            Assert.AreEqual("BG", Base36.Encode(412L));
            Assert.AreEqual("BH", Base36.Encode(413L));
            Assert.AreEqual("BI", Base36.Encode(414L));
            Assert.AreEqual("BJ", Base36.Encode(415L));
            Assert.AreEqual("BK", Base36.Encode(416L));
            Assert.AreEqual("BL", Base36.Encode(417L));
            Assert.AreEqual("BM", Base36.Encode(418L));
            Assert.AreEqual("BN", Base36.Encode(419L));
            Assert.AreEqual("BO", Base36.Encode(420L));
            Assert.AreEqual("BP", Base36.Encode(421L));
            Assert.AreEqual("BQ", Base36.Encode(422L));
            Assert.AreEqual("BR", Base36.Encode(423L));
            Assert.AreEqual("BS", Base36.Encode(424L));
            Assert.AreEqual("BT", Base36.Encode(425L));
            Assert.AreEqual("BU", Base36.Encode(426L));
            Assert.AreEqual("BV", Base36.Encode(427L));
            Assert.AreEqual("BW", Base36.Encode(428L));
            Assert.AreEqual("BX", Base36.Encode(429L));
            Assert.AreEqual("BY", Base36.Encode(430L));
            Assert.AreEqual("BZ", Base36.Encode(431L));

            #endregion

            #region C0 to CZ

            Assert.AreEqual("C0", Base36.Encode(432L));
            Assert.AreEqual("C1", Base36.Encode(433L));
            Assert.AreEqual("C2", Base36.Encode(434L));
            Assert.AreEqual("C3", Base36.Encode(435L));
            Assert.AreEqual("C4", Base36.Encode(436L));
            Assert.AreEqual("C5", Base36.Encode(437L));
            Assert.AreEqual("C6", Base36.Encode(438L));
            Assert.AreEqual("C7", Base36.Encode(439L));
            Assert.AreEqual("C8", Base36.Encode(440L));
            Assert.AreEqual("C9", Base36.Encode(441L));
            Assert.AreEqual("CA", Base36.Encode(442L));
            Assert.AreEqual("CB", Base36.Encode(443L));
            Assert.AreEqual("CC", Base36.Encode(444L));
            Assert.AreEqual("CD", Base36.Encode(445L));
            Assert.AreEqual("CE", Base36.Encode(446L));
            Assert.AreEqual("CF", Base36.Encode(447L));
            Assert.AreEqual("CG", Base36.Encode(448L));
            Assert.AreEqual("CH", Base36.Encode(449L));
            Assert.AreEqual("CI", Base36.Encode(450L));
            Assert.AreEqual("CJ", Base36.Encode(451L));
            Assert.AreEqual("CK", Base36.Encode(452L));
            Assert.AreEqual("CL", Base36.Encode(453L));
            Assert.AreEqual("CM", Base36.Encode(454L));
            Assert.AreEqual("CN", Base36.Encode(455L));
            Assert.AreEqual("CO", Base36.Encode(456L));
            Assert.AreEqual("CP", Base36.Encode(457L));
            Assert.AreEqual("CQ", Base36.Encode(458L));
            Assert.AreEqual("CR", Base36.Encode(459L));
            Assert.AreEqual("CS", Base36.Encode(460L));
            Assert.AreEqual("CT", Base36.Encode(461L));
            Assert.AreEqual("CU", Base36.Encode(462L));
            Assert.AreEqual("CV", Base36.Encode(463L));
            Assert.AreEqual("CW", Base36.Encode(464L));
            Assert.AreEqual("CX", Base36.Encode(465L));
            Assert.AreEqual("CY", Base36.Encode(466L));
            Assert.AreEqual("CZ", Base36.Encode(467L));

            #endregion

            #region D0 to DZ

            Assert.AreEqual("D0", Base36.Encode(468L));
            Assert.AreEqual("D1", Base36.Encode(469L));
            Assert.AreEqual("D2", Base36.Encode(470L));
            Assert.AreEqual("D3", Base36.Encode(471L));
            Assert.AreEqual("D4", Base36.Encode(472L));
            Assert.AreEqual("D5", Base36.Encode(473L));
            Assert.AreEqual("D6", Base36.Encode(474L));
            Assert.AreEqual("D7", Base36.Encode(475L));
            Assert.AreEqual("D8", Base36.Encode(476L));
            Assert.AreEqual("D9", Base36.Encode(477L));
            Assert.AreEqual("DA", Base36.Encode(478L));
            Assert.AreEqual("DB", Base36.Encode(479L));
            Assert.AreEqual("DC", Base36.Encode(480L));
            Assert.AreEqual("DD", Base36.Encode(481L));
            Assert.AreEqual("DE", Base36.Encode(482L));
            Assert.AreEqual("DF", Base36.Encode(483L));
            Assert.AreEqual("DG", Base36.Encode(484L));
            Assert.AreEqual("DH", Base36.Encode(485L));
            Assert.AreEqual("DI", Base36.Encode(486L));
            Assert.AreEqual("DJ", Base36.Encode(487L));
            Assert.AreEqual("DK", Base36.Encode(488L));
            Assert.AreEqual("DL", Base36.Encode(489L));
            Assert.AreEqual("DM", Base36.Encode(490L));
            Assert.AreEqual("DN", Base36.Encode(491L));
            Assert.AreEqual("DO", Base36.Encode(492L));
            Assert.AreEqual("DP", Base36.Encode(493L));
            Assert.AreEqual("DQ", Base36.Encode(494L));
            Assert.AreEqual("DR", Base36.Encode(495L));
            Assert.AreEqual("DS", Base36.Encode(496L));
            Assert.AreEqual("DT", Base36.Encode(497L));
            Assert.AreEqual("DU", Base36.Encode(498L));
            Assert.AreEqual("DV", Base36.Encode(499L));
            Assert.AreEqual("DW", Base36.Encode(500L));
            Assert.AreEqual("DX", Base36.Encode(501L));
            Assert.AreEqual("DY", Base36.Encode(502L));
            Assert.AreEqual("DZ", Base36.Encode(503L));

            #endregion

            #region E0 to EZ

            Assert.AreEqual("E0", Base36.Encode(504L));
            Assert.AreEqual("E1", Base36.Encode(505L));
            Assert.AreEqual("E2", Base36.Encode(506L));
            Assert.AreEqual("E3", Base36.Encode(507L));
            Assert.AreEqual("E4", Base36.Encode(508L));
            Assert.AreEqual("E5", Base36.Encode(509L));
            Assert.AreEqual("E6", Base36.Encode(510L));
            Assert.AreEqual("E7", Base36.Encode(511L));
            Assert.AreEqual("E8", Base36.Encode(512L));
            Assert.AreEqual("E9", Base36.Encode(513L));
            Assert.AreEqual("EA", Base36.Encode(514L));
            Assert.AreEqual("EB", Base36.Encode(515L));
            Assert.AreEqual("EC", Base36.Encode(516L));
            Assert.AreEqual("ED", Base36.Encode(517L));
            Assert.AreEqual("EE", Base36.Encode(518L));
            Assert.AreEqual("EF", Base36.Encode(519L));
            Assert.AreEqual("EG", Base36.Encode(520L));
            Assert.AreEqual("EH", Base36.Encode(521L));
            Assert.AreEqual("EI", Base36.Encode(522L));
            Assert.AreEqual("EJ", Base36.Encode(523L));
            Assert.AreEqual("EK", Base36.Encode(524L));
            Assert.AreEqual("EL", Base36.Encode(525L));
            Assert.AreEqual("EM", Base36.Encode(526L));
            Assert.AreEqual("EN", Base36.Encode(527L));
            Assert.AreEqual("EO", Base36.Encode(528L));
            Assert.AreEqual("EP", Base36.Encode(529L));
            Assert.AreEqual("EQ", Base36.Encode(530L));
            Assert.AreEqual("ER", Base36.Encode(531L));
            Assert.AreEqual("ES", Base36.Encode(532L));
            Assert.AreEqual("ET", Base36.Encode(533L));
            Assert.AreEqual("EU", Base36.Encode(534L));
            Assert.AreEqual("EV", Base36.Encode(535L));
            Assert.AreEqual("EW", Base36.Encode(536L));
            Assert.AreEqual("EX", Base36.Encode(537L));
            Assert.AreEqual("EY", Base36.Encode(538L));
            Assert.AreEqual("EZ", Base36.Encode(539L));

            #endregion

            #region F0 to FZ

            Assert.AreEqual("F0", Base36.Encode(540L));
            Assert.AreEqual("F1", Base36.Encode(541L));
            Assert.AreEqual("F2", Base36.Encode(542L));
            Assert.AreEqual("F3", Base36.Encode(543L));
            Assert.AreEqual("F4", Base36.Encode(544L));
            Assert.AreEqual("F5", Base36.Encode(545L));
            Assert.AreEqual("F6", Base36.Encode(546L));
            Assert.AreEqual("F7", Base36.Encode(547L));
            Assert.AreEqual("F8", Base36.Encode(548L));
            Assert.AreEqual("F9", Base36.Encode(549L));
            Assert.AreEqual("FA", Base36.Encode(550L));
            Assert.AreEqual("FB", Base36.Encode(551L));
            Assert.AreEqual("FC", Base36.Encode(552L));
            Assert.AreEqual("FD", Base36.Encode(553L));
            Assert.AreEqual("FE", Base36.Encode(554L));
            Assert.AreEqual("FF", Base36.Encode(555L));
            Assert.AreEqual("FG", Base36.Encode(556L));
            Assert.AreEqual("FH", Base36.Encode(557L));
            Assert.AreEqual("FI", Base36.Encode(558L));
            Assert.AreEqual("FJ", Base36.Encode(559L));
            Assert.AreEqual("FK", Base36.Encode(560L));
            Assert.AreEqual("FL", Base36.Encode(561L));
            Assert.AreEqual("FM", Base36.Encode(562L));
            Assert.AreEqual("FN", Base36.Encode(563L));
            Assert.AreEqual("FO", Base36.Encode(564L));
            Assert.AreEqual("FP", Base36.Encode(565L));
            Assert.AreEqual("FQ", Base36.Encode(566L));
            Assert.AreEqual("FR", Base36.Encode(567L));
            Assert.AreEqual("FS", Base36.Encode(568L));
            Assert.AreEqual("FT", Base36.Encode(569L));
            Assert.AreEqual("FU", Base36.Encode(570L));
            Assert.AreEqual("FV", Base36.Encode(571L));
            Assert.AreEqual("FW", Base36.Encode(572L));
            Assert.AreEqual("FX", Base36.Encode(573L));
            Assert.AreEqual("FY", Base36.Encode(574L));
            Assert.AreEqual("FZ", Base36.Encode(575L));

            #endregion

            #region G0 to GZ

            Assert.AreEqual("G0", Base36.Encode(576L));
            Assert.AreEqual("G1", Base36.Encode(577L));
            Assert.AreEqual("G2", Base36.Encode(578L));
            Assert.AreEqual("G3", Base36.Encode(579L));
            Assert.AreEqual("G4", Base36.Encode(580L));
            Assert.AreEqual("G5", Base36.Encode(581L));
            Assert.AreEqual("G6", Base36.Encode(582L));
            Assert.AreEqual("G7", Base36.Encode(583L));
            Assert.AreEqual("G8", Base36.Encode(584L));
            Assert.AreEqual("G9", Base36.Encode(585L));
            Assert.AreEqual("GA", Base36.Encode(586L));
            Assert.AreEqual("GB", Base36.Encode(587L));
            Assert.AreEqual("GC", Base36.Encode(588L));
            Assert.AreEqual("GD", Base36.Encode(589L));
            Assert.AreEqual("GE", Base36.Encode(590L));
            Assert.AreEqual("GF", Base36.Encode(591L));
            Assert.AreEqual("GG", Base36.Encode(592L));
            Assert.AreEqual("GH", Base36.Encode(593L));
            Assert.AreEqual("GI", Base36.Encode(594L));
            Assert.AreEqual("GJ", Base36.Encode(595L));
            Assert.AreEqual("GK", Base36.Encode(596L));
            Assert.AreEqual("GL", Base36.Encode(597L));
            Assert.AreEqual("GM", Base36.Encode(598L));
            Assert.AreEqual("GN", Base36.Encode(599L));
            Assert.AreEqual("GO", Base36.Encode(600L));
            Assert.AreEqual("GP", Base36.Encode(601L));
            Assert.AreEqual("GQ", Base36.Encode(602L));
            Assert.AreEqual("GR", Base36.Encode(603L));
            Assert.AreEqual("GS", Base36.Encode(604L));
            Assert.AreEqual("GT", Base36.Encode(605L));
            Assert.AreEqual("GU", Base36.Encode(606L));
            Assert.AreEqual("GV", Base36.Encode(607L));
            Assert.AreEqual("GW", Base36.Encode(608L));
            Assert.AreEqual("GX", Base36.Encode(609L));
            Assert.AreEqual("GY", Base36.Encode(610L));
            Assert.AreEqual("GZ", Base36.Encode(611L));

            #endregion

            #region H0 to HZ

            Assert.AreEqual("H0", Base36.Encode(612L));
            Assert.AreEqual("H1", Base36.Encode(613L));
            Assert.AreEqual("H2", Base36.Encode(614L));
            Assert.AreEqual("H3", Base36.Encode(615L));
            Assert.AreEqual("H4", Base36.Encode(616L));
            Assert.AreEqual("H5", Base36.Encode(617L));
            Assert.AreEqual("H6", Base36.Encode(618L));
            Assert.AreEqual("H7", Base36.Encode(619L));
            Assert.AreEqual("H8", Base36.Encode(620L));
            Assert.AreEqual("H9", Base36.Encode(621L));
            Assert.AreEqual("HA", Base36.Encode(622L));
            Assert.AreEqual("HB", Base36.Encode(623L));
            Assert.AreEqual("HC", Base36.Encode(624L));
            Assert.AreEqual("HD", Base36.Encode(625L));
            Assert.AreEqual("HE", Base36.Encode(626L));
            Assert.AreEqual("HF", Base36.Encode(627L));
            Assert.AreEqual("HG", Base36.Encode(628L));
            Assert.AreEqual("HH", Base36.Encode(629L));
            Assert.AreEqual("HI", Base36.Encode(630L));
            Assert.AreEqual("HJ", Base36.Encode(631L));
            Assert.AreEqual("HK", Base36.Encode(632L));
            Assert.AreEqual("HL", Base36.Encode(633L));
            Assert.AreEqual("HM", Base36.Encode(634L));
            Assert.AreEqual("HN", Base36.Encode(635L));
            Assert.AreEqual("HO", Base36.Encode(636L));
            Assert.AreEqual("HP", Base36.Encode(637L));
            Assert.AreEqual("HQ", Base36.Encode(638L));
            Assert.AreEqual("HR", Base36.Encode(639L));
            Assert.AreEqual("HS", Base36.Encode(640L));
            Assert.AreEqual("HT", Base36.Encode(641L));
            Assert.AreEqual("HU", Base36.Encode(642L));
            Assert.AreEqual("HV", Base36.Encode(643L));
            Assert.AreEqual("HW", Base36.Encode(644L));
            Assert.AreEqual("HX", Base36.Encode(645L));
            Assert.AreEqual("HY", Base36.Encode(646L));
            Assert.AreEqual("HZ", Base36.Encode(647L));

            #endregion

            #region I0 to IZ

            Assert.AreEqual("I0", Base36.Encode(648L));
            Assert.AreEqual("I1", Base36.Encode(649L));
            Assert.AreEqual("I2", Base36.Encode(650L));
            Assert.AreEqual("I3", Base36.Encode(651L));
            Assert.AreEqual("I4", Base36.Encode(652L));
            Assert.AreEqual("I5", Base36.Encode(653L));
            Assert.AreEqual("I6", Base36.Encode(654L));
            Assert.AreEqual("I7", Base36.Encode(655L));
            Assert.AreEqual("I8", Base36.Encode(656L));
            Assert.AreEqual("I9", Base36.Encode(657L));
            Assert.AreEqual("IA", Base36.Encode(658L));
            Assert.AreEqual("IB", Base36.Encode(659L));
            Assert.AreEqual("IC", Base36.Encode(660L));
            Assert.AreEqual("ID", Base36.Encode(661L));
            Assert.AreEqual("IE", Base36.Encode(662L));
            Assert.AreEqual("IF", Base36.Encode(663L));
            Assert.AreEqual("IG", Base36.Encode(664L));
            Assert.AreEqual("IH", Base36.Encode(665L));
            Assert.AreEqual("II", Base36.Encode(666L));
            Assert.AreEqual("IJ", Base36.Encode(667L));
            Assert.AreEqual("IK", Base36.Encode(668L));
            Assert.AreEqual("IL", Base36.Encode(669L));
            Assert.AreEqual("IM", Base36.Encode(670L));
            Assert.AreEqual("IN", Base36.Encode(671L));
            Assert.AreEqual("IO", Base36.Encode(672L));
            Assert.AreEqual("IP", Base36.Encode(673L));
            Assert.AreEqual("IQ", Base36.Encode(674L));
            Assert.AreEqual("IR", Base36.Encode(675L));
            Assert.AreEqual("IS", Base36.Encode(676L));
            Assert.AreEqual("IT", Base36.Encode(677L));
            Assert.AreEqual("IU", Base36.Encode(678L));
            Assert.AreEqual("IV", Base36.Encode(679L));
            Assert.AreEqual("IW", Base36.Encode(680L));
            Assert.AreEqual("IX", Base36.Encode(681L));
            Assert.AreEqual("IY", Base36.Encode(682L));
            Assert.AreEqual("IZ", Base36.Encode(683L));

            #endregion

            #region J0 to JZ

            Assert.AreEqual("J0", Base36.Encode(684L));
            Assert.AreEqual("J1", Base36.Encode(685L));
            Assert.AreEqual("J2", Base36.Encode(686L));
            Assert.AreEqual("J3", Base36.Encode(687L));
            Assert.AreEqual("J4", Base36.Encode(688L));
            Assert.AreEqual("J5", Base36.Encode(689L));
            Assert.AreEqual("J6", Base36.Encode(690L));
            Assert.AreEqual("J7", Base36.Encode(691L));
            Assert.AreEqual("J8", Base36.Encode(692L));
            Assert.AreEqual("J9", Base36.Encode(693L));
            Assert.AreEqual("JA", Base36.Encode(694L));
            Assert.AreEqual("JB", Base36.Encode(695L));
            Assert.AreEqual("JC", Base36.Encode(696L));
            Assert.AreEqual("JD", Base36.Encode(697L));
            Assert.AreEqual("JE", Base36.Encode(698L));
            Assert.AreEqual("JF", Base36.Encode(699L));
            Assert.AreEqual("JG", Base36.Encode(700L));
            Assert.AreEqual("JH", Base36.Encode(701L));
            Assert.AreEqual("JI", Base36.Encode(702L));
            Assert.AreEqual("JJ", Base36.Encode(703L));
            Assert.AreEqual("JK", Base36.Encode(704L));
            Assert.AreEqual("JL", Base36.Encode(705L));
            Assert.AreEqual("JM", Base36.Encode(706L));
            Assert.AreEqual("JN", Base36.Encode(707L));
            Assert.AreEqual("JO", Base36.Encode(708L));
            Assert.AreEqual("JP", Base36.Encode(709L));
            Assert.AreEqual("JQ", Base36.Encode(710L));
            Assert.AreEqual("JR", Base36.Encode(711L));
            Assert.AreEqual("JS", Base36.Encode(712L));
            Assert.AreEqual("JT", Base36.Encode(713L));
            Assert.AreEqual("JU", Base36.Encode(714L));
            Assert.AreEqual("JV", Base36.Encode(715L));
            Assert.AreEqual("JW", Base36.Encode(716L));
            Assert.AreEqual("JX", Base36.Encode(717L));
            Assert.AreEqual("JY", Base36.Encode(718L));
            Assert.AreEqual("JZ", Base36.Encode(719L));

            #endregion

            #region K0 to KZ

            Assert.AreEqual("K0", Base36.Encode(720L));
            Assert.AreEqual("K1", Base36.Encode(721L));
            Assert.AreEqual("K2", Base36.Encode(722L));
            Assert.AreEqual("K3", Base36.Encode(723L));
            Assert.AreEqual("K4", Base36.Encode(724L));
            Assert.AreEqual("K5", Base36.Encode(725L));
            Assert.AreEqual("K6", Base36.Encode(726L));
            Assert.AreEqual("K7", Base36.Encode(727L));
            Assert.AreEqual("K8", Base36.Encode(728L));
            Assert.AreEqual("K9", Base36.Encode(729L));
            Assert.AreEqual("KA", Base36.Encode(730L));
            Assert.AreEqual("KB", Base36.Encode(731L));
            Assert.AreEqual("KC", Base36.Encode(732L));
            Assert.AreEqual("KD", Base36.Encode(733L));
            Assert.AreEqual("KE", Base36.Encode(734L));
            Assert.AreEqual("KF", Base36.Encode(735L));
            Assert.AreEqual("KG", Base36.Encode(736L));
            Assert.AreEqual("KH", Base36.Encode(737L));
            Assert.AreEqual("KI", Base36.Encode(738L));
            Assert.AreEqual("KJ", Base36.Encode(739L));
            Assert.AreEqual("KK", Base36.Encode(740L));
            Assert.AreEqual("KL", Base36.Encode(741L));
            Assert.AreEqual("KM", Base36.Encode(742L));
            Assert.AreEqual("KN", Base36.Encode(743L));
            Assert.AreEqual("KO", Base36.Encode(744L));
            Assert.AreEqual("KP", Base36.Encode(745L));
            Assert.AreEqual("KQ", Base36.Encode(746L));
            Assert.AreEqual("KR", Base36.Encode(747L));
            Assert.AreEqual("KS", Base36.Encode(748L));
            Assert.AreEqual("KT", Base36.Encode(749L));
            Assert.AreEqual("KU", Base36.Encode(750L));
            Assert.AreEqual("KV", Base36.Encode(751L));
            Assert.AreEqual("KW", Base36.Encode(752L));
            Assert.AreEqual("KX", Base36.Encode(753L));
            Assert.AreEqual("KY", Base36.Encode(754L));
            Assert.AreEqual("KZ", Base36.Encode(755L));

            #endregion

            #region L0 to LZ

            Assert.AreEqual("L0", Base36.Encode(756L));
            Assert.AreEqual("L1", Base36.Encode(757L));
            Assert.AreEqual("L2", Base36.Encode(758L));
            Assert.AreEqual("L3", Base36.Encode(759L));
            Assert.AreEqual("L4", Base36.Encode(760L));
            Assert.AreEqual("L5", Base36.Encode(761L));
            Assert.AreEqual("L6", Base36.Encode(762L));
            Assert.AreEqual("L7", Base36.Encode(763L));
            Assert.AreEqual("L8", Base36.Encode(764L));
            Assert.AreEqual("L9", Base36.Encode(765L));
            Assert.AreEqual("LA", Base36.Encode(766L));
            Assert.AreEqual("LB", Base36.Encode(767L));
            Assert.AreEqual("LC", Base36.Encode(768L));
            Assert.AreEqual("LD", Base36.Encode(769L));
            Assert.AreEqual("LE", Base36.Encode(770L));
            Assert.AreEqual("LF", Base36.Encode(771L));
            Assert.AreEqual("LG", Base36.Encode(772L));
            Assert.AreEqual("LH", Base36.Encode(773L));
            Assert.AreEqual("LI", Base36.Encode(774L));
            Assert.AreEqual("LJ", Base36.Encode(775L));
            Assert.AreEqual("LK", Base36.Encode(776L));
            Assert.AreEqual("LL", Base36.Encode(777L));
            Assert.AreEqual("LM", Base36.Encode(778L));
            Assert.AreEqual("LN", Base36.Encode(779L));
            Assert.AreEqual("LO", Base36.Encode(780L));
            Assert.AreEqual("LP", Base36.Encode(781L));
            Assert.AreEqual("LQ", Base36.Encode(782L));
            Assert.AreEqual("LR", Base36.Encode(783L));
            Assert.AreEqual("LS", Base36.Encode(784L));
            Assert.AreEqual("LT", Base36.Encode(785L));
            Assert.AreEqual("LU", Base36.Encode(786L));
            Assert.AreEqual("LV", Base36.Encode(787L));
            Assert.AreEqual("LW", Base36.Encode(788L));
            Assert.AreEqual("LX", Base36.Encode(789L));
            Assert.AreEqual("LY", Base36.Encode(790L));
            Assert.AreEqual("LZ", Base36.Encode(791L));

            #endregion

            #region M0 to MZ

            Assert.AreEqual("M0", Base36.Encode(792L));
            Assert.AreEqual("M1", Base36.Encode(793L));
            Assert.AreEqual("M2", Base36.Encode(794L));
            Assert.AreEqual("M3", Base36.Encode(795L));
            Assert.AreEqual("M4", Base36.Encode(796L));
            Assert.AreEqual("M5", Base36.Encode(797L));
            Assert.AreEqual("M6", Base36.Encode(798L));
            Assert.AreEqual("M7", Base36.Encode(799L));
            Assert.AreEqual("M8", Base36.Encode(800L));
            Assert.AreEqual("M9", Base36.Encode(801L));
            Assert.AreEqual("MA", Base36.Encode(802L));
            Assert.AreEqual("MB", Base36.Encode(803L));
            Assert.AreEqual("MC", Base36.Encode(804L));
            Assert.AreEqual("MD", Base36.Encode(805L));
            Assert.AreEqual("ME", Base36.Encode(806L));
            Assert.AreEqual("MF", Base36.Encode(807L));
            Assert.AreEqual("MG", Base36.Encode(808L));
            Assert.AreEqual("MH", Base36.Encode(809L));
            Assert.AreEqual("MI", Base36.Encode(810L));
            Assert.AreEqual("MJ", Base36.Encode(811L));
            Assert.AreEqual("MK", Base36.Encode(812L));
            Assert.AreEqual("ML", Base36.Encode(813L));
            Assert.AreEqual("MM", Base36.Encode(814L));
            Assert.AreEqual("MN", Base36.Encode(815L));
            Assert.AreEqual("MO", Base36.Encode(816L));
            Assert.AreEqual("MP", Base36.Encode(817L));
            Assert.AreEqual("MQ", Base36.Encode(818L));
            Assert.AreEqual("MR", Base36.Encode(819L));
            Assert.AreEqual("MS", Base36.Encode(820L));
            Assert.AreEqual("MT", Base36.Encode(821L));
            Assert.AreEqual("MU", Base36.Encode(822L));
            Assert.AreEqual("MV", Base36.Encode(823L));
            Assert.AreEqual("MW", Base36.Encode(824L));
            Assert.AreEqual("MX", Base36.Encode(825L));
            Assert.AreEqual("MY", Base36.Encode(826L));
            Assert.AreEqual("MZ", Base36.Encode(827L));

            #endregion

            #region N0 to NZ

            Assert.AreEqual("N0", Base36.Encode(828L));
            Assert.AreEqual("N1", Base36.Encode(829L));
            Assert.AreEqual("N2", Base36.Encode(830L));
            Assert.AreEqual("N3", Base36.Encode(831L));
            Assert.AreEqual("N4", Base36.Encode(832L));
            Assert.AreEqual("N5", Base36.Encode(833L));
            Assert.AreEqual("N6", Base36.Encode(834L));
            Assert.AreEqual("N7", Base36.Encode(835L));
            Assert.AreEqual("N8", Base36.Encode(836L));
            Assert.AreEqual("N9", Base36.Encode(837L));
            Assert.AreEqual("NA", Base36.Encode(838L));
            Assert.AreEqual("NB", Base36.Encode(839L));
            Assert.AreEqual("NC", Base36.Encode(840L));
            Assert.AreEqual("ND", Base36.Encode(841L));
            Assert.AreEqual("NE", Base36.Encode(842L));
            Assert.AreEqual("NF", Base36.Encode(843L));
            Assert.AreEqual("NG", Base36.Encode(844L));
            Assert.AreEqual("NH", Base36.Encode(845L));
            Assert.AreEqual("NI", Base36.Encode(846L));
            Assert.AreEqual("NJ", Base36.Encode(847L));
            Assert.AreEqual("NK", Base36.Encode(848L));
            Assert.AreEqual("NL", Base36.Encode(849L));
            Assert.AreEqual("NM", Base36.Encode(850L));
            Assert.AreEqual("NN", Base36.Encode(851L));
            Assert.AreEqual("NO", Base36.Encode(852L));
            Assert.AreEqual("NP", Base36.Encode(853L));
            Assert.AreEqual("NQ", Base36.Encode(854L));
            Assert.AreEqual("NR", Base36.Encode(855L));
            Assert.AreEqual("NS", Base36.Encode(856L));
            Assert.AreEqual("NT", Base36.Encode(857L));
            Assert.AreEqual("NU", Base36.Encode(858L));
            Assert.AreEqual("NV", Base36.Encode(859L));
            Assert.AreEqual("NW", Base36.Encode(860L));
            Assert.AreEqual("NX", Base36.Encode(861L));
            Assert.AreEqual("NY", Base36.Encode(862L));
            Assert.AreEqual("NZ", Base36.Encode(863L));

            #endregion

            #region O0 to OZ

            Assert.AreEqual("O0", Base36.Encode(864L));
            Assert.AreEqual("O1", Base36.Encode(865L));
            Assert.AreEqual("O2", Base36.Encode(866L));
            Assert.AreEqual("O3", Base36.Encode(867L));
            Assert.AreEqual("O4", Base36.Encode(868L));
            Assert.AreEqual("O5", Base36.Encode(869L));
            Assert.AreEqual("O6", Base36.Encode(870L));
            Assert.AreEqual("O7", Base36.Encode(871L));
            Assert.AreEqual("O8", Base36.Encode(872L));
            Assert.AreEqual("O9", Base36.Encode(873L));
            Assert.AreEqual("OA", Base36.Encode(874L));
            Assert.AreEqual("OB", Base36.Encode(875L));
            Assert.AreEqual("OC", Base36.Encode(876L));
            Assert.AreEqual("OD", Base36.Encode(877L));
            Assert.AreEqual("OE", Base36.Encode(878L));
            Assert.AreEqual("OF", Base36.Encode(879L));
            Assert.AreEqual("OG", Base36.Encode(880L));
            Assert.AreEqual("OH", Base36.Encode(881L));
            Assert.AreEqual("OI", Base36.Encode(882L));
            Assert.AreEqual("OJ", Base36.Encode(883L));
            Assert.AreEqual("OK", Base36.Encode(884L));
            Assert.AreEqual("OL", Base36.Encode(885L));
            Assert.AreEqual("OM", Base36.Encode(886L));
            Assert.AreEqual("ON", Base36.Encode(887L));
            Assert.AreEqual("OO", Base36.Encode(888L));
            Assert.AreEqual("OP", Base36.Encode(889L));
            Assert.AreEqual("OQ", Base36.Encode(890L));
            Assert.AreEqual("OR", Base36.Encode(891L));
            Assert.AreEqual("OS", Base36.Encode(892L));
            Assert.AreEqual("OT", Base36.Encode(893L));
            Assert.AreEqual("OU", Base36.Encode(894L));
            Assert.AreEqual("OV", Base36.Encode(895L));
            Assert.AreEqual("OW", Base36.Encode(896L));
            Assert.AreEqual("OX", Base36.Encode(897L));
            Assert.AreEqual("OY", Base36.Encode(898L));
            Assert.AreEqual("OZ", Base36.Encode(899L));

            #endregion

            #region P0 to PZ

            Assert.AreEqual("P0", Base36.Encode(900L));
            Assert.AreEqual("P1", Base36.Encode(901L));
            Assert.AreEqual("P2", Base36.Encode(902L));
            Assert.AreEqual("P3", Base36.Encode(903L));
            Assert.AreEqual("P4", Base36.Encode(904L));
            Assert.AreEqual("P5", Base36.Encode(905L));
            Assert.AreEqual("P6", Base36.Encode(906L));
            Assert.AreEqual("P7", Base36.Encode(907L));
            Assert.AreEqual("P8", Base36.Encode(908L));
            Assert.AreEqual("P9", Base36.Encode(909L));
            Assert.AreEqual("PA", Base36.Encode(910L));
            Assert.AreEqual("PB", Base36.Encode(911L));
            Assert.AreEqual("PC", Base36.Encode(912L));
            Assert.AreEqual("PD", Base36.Encode(913L));
            Assert.AreEqual("PE", Base36.Encode(914L));
            Assert.AreEqual("PF", Base36.Encode(915L));
            Assert.AreEqual("PG", Base36.Encode(916L));
            Assert.AreEqual("PH", Base36.Encode(917L));
            Assert.AreEqual("PI", Base36.Encode(918L));
            Assert.AreEqual("PJ", Base36.Encode(919L));
            Assert.AreEqual("PK", Base36.Encode(920L));
            Assert.AreEqual("PL", Base36.Encode(921L));
            Assert.AreEqual("PM", Base36.Encode(922L));
            Assert.AreEqual("PN", Base36.Encode(923L));
            Assert.AreEqual("PO", Base36.Encode(924L));
            Assert.AreEqual("PP", Base36.Encode(925L));
            Assert.AreEqual("PQ", Base36.Encode(926L));
            Assert.AreEqual("PR", Base36.Encode(927L));
            Assert.AreEqual("PS", Base36.Encode(928L));
            Assert.AreEqual("PT", Base36.Encode(929L));
            Assert.AreEqual("PU", Base36.Encode(930L));
            Assert.AreEqual("PV", Base36.Encode(931L));
            Assert.AreEqual("PW", Base36.Encode(932L));
            Assert.AreEqual("PX", Base36.Encode(933L));
            Assert.AreEqual("PY", Base36.Encode(934L));
            Assert.AreEqual("PZ", Base36.Encode(935L));

            #endregion

            #region Q0 to QZ

            Assert.AreEqual("Q0", Base36.Encode(936L));
            Assert.AreEqual("Q1", Base36.Encode(937L));
            Assert.AreEqual("Q2", Base36.Encode(938L));
            Assert.AreEqual("Q3", Base36.Encode(939L));
            Assert.AreEqual("Q4", Base36.Encode(940L));
            Assert.AreEqual("Q5", Base36.Encode(941L));
            Assert.AreEqual("Q6", Base36.Encode(942L));
            Assert.AreEqual("Q7", Base36.Encode(943L));
            Assert.AreEqual("Q8", Base36.Encode(944L));
            Assert.AreEqual("Q9", Base36.Encode(945L));
            Assert.AreEqual("QA", Base36.Encode(946L));
            Assert.AreEqual("QB", Base36.Encode(947L));
            Assert.AreEqual("QC", Base36.Encode(948L));
            Assert.AreEqual("QD", Base36.Encode(949L));
            Assert.AreEqual("QE", Base36.Encode(950L));
            Assert.AreEqual("QF", Base36.Encode(951L));
            Assert.AreEqual("QG", Base36.Encode(952L));
            Assert.AreEqual("QH", Base36.Encode(953L));
            Assert.AreEqual("QI", Base36.Encode(954L));
            Assert.AreEqual("QJ", Base36.Encode(955L));
            Assert.AreEqual("QK", Base36.Encode(956L));
            Assert.AreEqual("QL", Base36.Encode(957L));
            Assert.AreEqual("QM", Base36.Encode(958L));
            Assert.AreEqual("QN", Base36.Encode(959L));
            Assert.AreEqual("QO", Base36.Encode(960L));
            Assert.AreEqual("QP", Base36.Encode(961L));
            Assert.AreEqual("QQ", Base36.Encode(962L));
            Assert.AreEqual("QR", Base36.Encode(963L));
            Assert.AreEqual("QS", Base36.Encode(964L));
            Assert.AreEqual("QT", Base36.Encode(965L));
            Assert.AreEqual("QU", Base36.Encode(966L));
            Assert.AreEqual("QV", Base36.Encode(967L));
            Assert.AreEqual("QW", Base36.Encode(968L));
            Assert.AreEqual("QX", Base36.Encode(969L));
            Assert.AreEqual("QY", Base36.Encode(970L));
            Assert.AreEqual("QZ", Base36.Encode(971L));

            #endregion

            #region R0 to RZ

            Assert.AreEqual("R0", Base36.Encode(972L));
            Assert.AreEqual("R1", Base36.Encode(973L));
            Assert.AreEqual("R2", Base36.Encode(974L));
            Assert.AreEqual("R3", Base36.Encode(975L));
            Assert.AreEqual("R4", Base36.Encode(976L));
            Assert.AreEqual("R5", Base36.Encode(977L));
            Assert.AreEqual("R6", Base36.Encode(978L));
            Assert.AreEqual("R7", Base36.Encode(979L));
            Assert.AreEqual("R8", Base36.Encode(980L));
            Assert.AreEqual("R9", Base36.Encode(981L));
            Assert.AreEqual("RA", Base36.Encode(982L));
            Assert.AreEqual("RB", Base36.Encode(983L));
            Assert.AreEqual("RC", Base36.Encode(984L));
            Assert.AreEqual("RD", Base36.Encode(985L));
            Assert.AreEqual("RE", Base36.Encode(986L));
            Assert.AreEqual("RF", Base36.Encode(987L));
            Assert.AreEqual("RG", Base36.Encode(988L));
            Assert.AreEqual("RH", Base36.Encode(989L));
            Assert.AreEqual("RI", Base36.Encode(990L));
            Assert.AreEqual("RJ", Base36.Encode(991L));
            Assert.AreEqual("RK", Base36.Encode(992L));
            Assert.AreEqual("RL", Base36.Encode(993L));
            Assert.AreEqual("RM", Base36.Encode(994L));
            Assert.AreEqual("RN", Base36.Encode(995L));
            Assert.AreEqual("RO", Base36.Encode(996L));
            Assert.AreEqual("RP", Base36.Encode(997L));
            Assert.AreEqual("RQ", Base36.Encode(998L));
            Assert.AreEqual("RR", Base36.Encode(999L));
            Assert.AreEqual("RS", Base36.Encode(1000L));
            Assert.AreEqual("RT", Base36.Encode(1001L));
            Assert.AreEqual("RU", Base36.Encode(1002L));
            Assert.AreEqual("RV", Base36.Encode(1003L));
            Assert.AreEqual("RW", Base36.Encode(1004L));
            Assert.AreEqual("RX", Base36.Encode(1005L));
            Assert.AreEqual("RY", Base36.Encode(1006L));
            Assert.AreEqual("RZ", Base36.Encode(1007L));

            #endregion

            #region S0 to SZ

            Assert.AreEqual("S0", Base36.Encode(1008L));
            Assert.AreEqual("S1", Base36.Encode(1009L));
            Assert.AreEqual("S2", Base36.Encode(1010L));
            Assert.AreEqual("S3", Base36.Encode(1011L));
            Assert.AreEqual("S4", Base36.Encode(1012L));
            Assert.AreEqual("S5", Base36.Encode(1013L));
            Assert.AreEqual("S6", Base36.Encode(1014L));
            Assert.AreEqual("S7", Base36.Encode(1015L));
            Assert.AreEqual("S8", Base36.Encode(1016L));
            Assert.AreEqual("S9", Base36.Encode(1017L));
            Assert.AreEqual("SA", Base36.Encode(1018L));
            Assert.AreEqual("SB", Base36.Encode(1019L));
            Assert.AreEqual("SC", Base36.Encode(1020L));
            Assert.AreEqual("SD", Base36.Encode(1021L));
            Assert.AreEqual("SE", Base36.Encode(1022L));
            Assert.AreEqual("SF", Base36.Encode(1023L));
            Assert.AreEqual("SG", Base36.Encode(1024L));
            Assert.AreEqual("SH", Base36.Encode(1025L));
            Assert.AreEqual("SI", Base36.Encode(1026L));
            Assert.AreEqual("SJ", Base36.Encode(1027L));
            Assert.AreEqual("SK", Base36.Encode(1028L));
            Assert.AreEqual("SL", Base36.Encode(1029L));
            Assert.AreEqual("SM", Base36.Encode(1030L));
            Assert.AreEqual("SN", Base36.Encode(1031L));
            Assert.AreEqual("SO", Base36.Encode(1032L));
            Assert.AreEqual("SP", Base36.Encode(1033L));
            Assert.AreEqual("SQ", Base36.Encode(1034L));
            Assert.AreEqual("SR", Base36.Encode(1035L));
            Assert.AreEqual("SS", Base36.Encode(1036L));
            Assert.AreEqual("ST", Base36.Encode(1037L));
            Assert.AreEqual("SU", Base36.Encode(1038L));
            Assert.AreEqual("SV", Base36.Encode(1039L));
            Assert.AreEqual("SW", Base36.Encode(1040L));
            Assert.AreEqual("SX", Base36.Encode(1041L));
            Assert.AreEqual("SY", Base36.Encode(1042L));
            Assert.AreEqual("SZ", Base36.Encode(1043L));

            #endregion

            #region T0 to TZ

            Assert.AreEqual("T0", Base36.Encode(1044L));
            Assert.AreEqual("T1", Base36.Encode(1045L));
            Assert.AreEqual("T2", Base36.Encode(1046L));
            Assert.AreEqual("T3", Base36.Encode(1047L));
            Assert.AreEqual("T4", Base36.Encode(1048L));
            Assert.AreEqual("T5", Base36.Encode(1049L));
            Assert.AreEqual("T6", Base36.Encode(1050L));
            Assert.AreEqual("T7", Base36.Encode(1051L));
            Assert.AreEqual("T8", Base36.Encode(1052L));
            Assert.AreEqual("T9", Base36.Encode(1053L));
            Assert.AreEqual("TA", Base36.Encode(1054L));
            Assert.AreEqual("TB", Base36.Encode(1055L));
            Assert.AreEqual("TC", Base36.Encode(1056L));
            Assert.AreEqual("TD", Base36.Encode(1057L));
            Assert.AreEqual("TE", Base36.Encode(1058L));
            Assert.AreEqual("TF", Base36.Encode(1059L));
            Assert.AreEqual("TG", Base36.Encode(1060L));
            Assert.AreEqual("TH", Base36.Encode(1061L));
            Assert.AreEqual("TI", Base36.Encode(1062L));
            Assert.AreEqual("TJ", Base36.Encode(1063L));
            Assert.AreEqual("TK", Base36.Encode(1064L));
            Assert.AreEqual("TL", Base36.Encode(1065L));
            Assert.AreEqual("TM", Base36.Encode(1066L));
            Assert.AreEqual("TN", Base36.Encode(1067L));
            Assert.AreEqual("TO", Base36.Encode(1068L));
            Assert.AreEqual("TP", Base36.Encode(1069L));
            Assert.AreEqual("TQ", Base36.Encode(1070L));
            Assert.AreEqual("TR", Base36.Encode(1071L));
            Assert.AreEqual("TS", Base36.Encode(1072L));
            Assert.AreEqual("TT", Base36.Encode(1073L));
            Assert.AreEqual("TU", Base36.Encode(1074L));
            Assert.AreEqual("TV", Base36.Encode(1075L));
            Assert.AreEqual("TW", Base36.Encode(1076L));
            Assert.AreEqual("TX", Base36.Encode(1077L));
            Assert.AreEqual("TY", Base36.Encode(1078L));
            Assert.AreEqual("TZ", Base36.Encode(1079L));

            #endregion

            #region U0 to UZ

            Assert.AreEqual("U0", Base36.Encode(1080L));
            Assert.AreEqual("U1", Base36.Encode(1081L));
            Assert.AreEqual("U2", Base36.Encode(1082L));
            Assert.AreEqual("U3", Base36.Encode(1083L));
            Assert.AreEqual("U4", Base36.Encode(1084L));
            Assert.AreEqual("U5", Base36.Encode(1085L));
            Assert.AreEqual("U6", Base36.Encode(1086L));
            Assert.AreEqual("U7", Base36.Encode(1087L));
            Assert.AreEqual("U8", Base36.Encode(1088L));
            Assert.AreEqual("U9", Base36.Encode(1089L));
            Assert.AreEqual("UA", Base36.Encode(1090L));
            Assert.AreEqual("UB", Base36.Encode(1091L));
            Assert.AreEqual("UC", Base36.Encode(1092L));
            Assert.AreEqual("UD", Base36.Encode(1093L));
            Assert.AreEqual("UE", Base36.Encode(1094L));
            Assert.AreEqual("UF", Base36.Encode(1095L));
            Assert.AreEqual("UG", Base36.Encode(1096L));
            Assert.AreEqual("UH", Base36.Encode(1097L));
            Assert.AreEqual("UI", Base36.Encode(1098L));
            Assert.AreEqual("UJ", Base36.Encode(1099L));
            Assert.AreEqual("UK", Base36.Encode(1100L));
            Assert.AreEqual("UL", Base36.Encode(1101L));
            Assert.AreEqual("UM", Base36.Encode(1102L));
            Assert.AreEqual("UN", Base36.Encode(1103L));
            Assert.AreEqual("UO", Base36.Encode(1104L));
            Assert.AreEqual("UP", Base36.Encode(1105L));
            Assert.AreEqual("UQ", Base36.Encode(1106L));
            Assert.AreEqual("UR", Base36.Encode(1107L));
            Assert.AreEqual("US", Base36.Encode(1108L));
            Assert.AreEqual("UT", Base36.Encode(1109L));
            Assert.AreEqual("UU", Base36.Encode(1110L));
            Assert.AreEqual("UV", Base36.Encode(1111L));
            Assert.AreEqual("UW", Base36.Encode(1112L));
            Assert.AreEqual("UX", Base36.Encode(1113L));
            Assert.AreEqual("UY", Base36.Encode(1114L));
            Assert.AreEqual("UZ", Base36.Encode(1115L));

            #endregion

            #region V0 to VZ

            Assert.AreEqual("V0", Base36.Encode(1116L));
            Assert.AreEqual("V1", Base36.Encode(1117L));
            Assert.AreEqual("V2", Base36.Encode(1118L));
            Assert.AreEqual("V3", Base36.Encode(1119L));
            Assert.AreEqual("V4", Base36.Encode(1120L));
            Assert.AreEqual("V5", Base36.Encode(1121L));
            Assert.AreEqual("V6", Base36.Encode(1122L));
            Assert.AreEqual("V7", Base36.Encode(1123L));
            Assert.AreEqual("V8", Base36.Encode(1124L));
            Assert.AreEqual("V9", Base36.Encode(1125L));
            Assert.AreEqual("VA", Base36.Encode(1126L));
            Assert.AreEqual("VB", Base36.Encode(1127L));
            Assert.AreEqual("VC", Base36.Encode(1128L));
            Assert.AreEqual("VD", Base36.Encode(1129L));
            Assert.AreEqual("VE", Base36.Encode(1130L));
            Assert.AreEqual("VF", Base36.Encode(1131L));
            Assert.AreEqual("VG", Base36.Encode(1132L));
            Assert.AreEqual("VH", Base36.Encode(1133L));
            Assert.AreEqual("VI", Base36.Encode(1134L));
            Assert.AreEqual("VJ", Base36.Encode(1135L));
            Assert.AreEqual("VK", Base36.Encode(1136L));
            Assert.AreEqual("VL", Base36.Encode(1137L));
            Assert.AreEqual("VM", Base36.Encode(1138L));
            Assert.AreEqual("VN", Base36.Encode(1139L));
            Assert.AreEqual("VO", Base36.Encode(1140L));
            Assert.AreEqual("VP", Base36.Encode(1141L));
            Assert.AreEqual("VQ", Base36.Encode(1142L));
            Assert.AreEqual("VR", Base36.Encode(1143L));
            Assert.AreEqual("VS", Base36.Encode(1144L));
            Assert.AreEqual("VT", Base36.Encode(1145L));
            Assert.AreEqual("VU", Base36.Encode(1146L));
            Assert.AreEqual("VV", Base36.Encode(1147L));
            Assert.AreEqual("VW", Base36.Encode(1148L));
            Assert.AreEqual("VX", Base36.Encode(1149L));
            Assert.AreEqual("VY", Base36.Encode(1150L));
            Assert.AreEqual("VZ", Base36.Encode(1151L));

            #endregion

            #region W0 to WZ

            Assert.AreEqual("W0", Base36.Encode(1152L));
            Assert.AreEqual("W1", Base36.Encode(1153L));
            Assert.AreEqual("W2", Base36.Encode(1154L));
            Assert.AreEqual("W3", Base36.Encode(1155L));
            Assert.AreEqual("W4", Base36.Encode(1156L));
            Assert.AreEqual("W5", Base36.Encode(1157L));
            Assert.AreEqual("W6", Base36.Encode(1158L));
            Assert.AreEqual("W7", Base36.Encode(1159L));
            Assert.AreEqual("W8", Base36.Encode(1160L));
            Assert.AreEqual("W9", Base36.Encode(1161L));
            Assert.AreEqual("WA", Base36.Encode(1162L));
            Assert.AreEqual("WB", Base36.Encode(1163L));
            Assert.AreEqual("WC", Base36.Encode(1164L));
            Assert.AreEqual("WD", Base36.Encode(1165L));
            Assert.AreEqual("WE", Base36.Encode(1166L));
            Assert.AreEqual("WF", Base36.Encode(1167L));
            Assert.AreEqual("WG", Base36.Encode(1168L));
            Assert.AreEqual("WH", Base36.Encode(1169L));
            Assert.AreEqual("WI", Base36.Encode(1170L));
            Assert.AreEqual("WJ", Base36.Encode(1171L));
            Assert.AreEqual("WK", Base36.Encode(1172L));
            Assert.AreEqual("WL", Base36.Encode(1173L));
            Assert.AreEqual("WM", Base36.Encode(1174L));
            Assert.AreEqual("WN", Base36.Encode(1175L));
            Assert.AreEqual("WO", Base36.Encode(1176L));
            Assert.AreEqual("WP", Base36.Encode(1177L));
            Assert.AreEqual("WQ", Base36.Encode(1178L));
            Assert.AreEqual("WR", Base36.Encode(1179L));
            Assert.AreEqual("WS", Base36.Encode(1180L));
            Assert.AreEqual("WT", Base36.Encode(1181L));
            Assert.AreEqual("WU", Base36.Encode(1182L));
            Assert.AreEqual("WV", Base36.Encode(1183L));
            Assert.AreEqual("WW", Base36.Encode(1184L));
            Assert.AreEqual("WX", Base36.Encode(1185L));
            Assert.AreEqual("WY", Base36.Encode(1186L));
            Assert.AreEqual("WZ", Base36.Encode(1187L));

            #endregion

            #region X0 to XZ

            Assert.AreEqual("X0", Base36.Encode(1188L));
            Assert.AreEqual("X1", Base36.Encode(1189L));
            Assert.AreEqual("X2", Base36.Encode(1190L));
            Assert.AreEqual("X3", Base36.Encode(1191L));
            Assert.AreEqual("X4", Base36.Encode(1192L));
            Assert.AreEqual("X5", Base36.Encode(1193L));
            Assert.AreEqual("X6", Base36.Encode(1194L));
            Assert.AreEqual("X7", Base36.Encode(1195L));
            Assert.AreEqual("X8", Base36.Encode(1196L));
            Assert.AreEqual("X9", Base36.Encode(1197L));
            Assert.AreEqual("XA", Base36.Encode(1198L));
            Assert.AreEqual("XB", Base36.Encode(1199L));
            Assert.AreEqual("XC", Base36.Encode(1200L));
            Assert.AreEqual("XD", Base36.Encode(1201L));
            Assert.AreEqual("XE", Base36.Encode(1202L));
            Assert.AreEqual("XF", Base36.Encode(1203L));
            Assert.AreEqual("XG", Base36.Encode(1204L));
            Assert.AreEqual("XH", Base36.Encode(1205L));
            Assert.AreEqual("XI", Base36.Encode(1206L));
            Assert.AreEqual("XJ", Base36.Encode(1207L));
            Assert.AreEqual("XK", Base36.Encode(1208L));
            Assert.AreEqual("XL", Base36.Encode(1209L));
            Assert.AreEqual("XM", Base36.Encode(1210L));
            Assert.AreEqual("XN", Base36.Encode(1211L));
            Assert.AreEqual("XO", Base36.Encode(1212L));
            Assert.AreEqual("XP", Base36.Encode(1213L));
            Assert.AreEqual("XQ", Base36.Encode(1214L));
            Assert.AreEqual("XR", Base36.Encode(1215L));
            Assert.AreEqual("XS", Base36.Encode(1216L));
            Assert.AreEqual("XT", Base36.Encode(1217L));
            Assert.AreEqual("XU", Base36.Encode(1218L));
            Assert.AreEqual("XV", Base36.Encode(1219L));
            Assert.AreEqual("XW", Base36.Encode(1220L));
            Assert.AreEqual("XX", Base36.Encode(1221L));
            Assert.AreEqual("XY", Base36.Encode(1222L));
            Assert.AreEqual("XZ", Base36.Encode(1223L));

            #endregion

            #region Y0 to YZ

            Assert.AreEqual("Y0", Base36.Encode(1224L));
            Assert.AreEqual("Y1", Base36.Encode(1225L));
            Assert.AreEqual("Y2", Base36.Encode(1226L));
            Assert.AreEqual("Y3", Base36.Encode(1227L));
            Assert.AreEqual("Y4", Base36.Encode(1228L));
            Assert.AreEqual("Y5", Base36.Encode(1229L));
            Assert.AreEqual("Y6", Base36.Encode(1230L));
            Assert.AreEqual("Y7", Base36.Encode(1231L));
            Assert.AreEqual("Y8", Base36.Encode(1232L));
            Assert.AreEqual("Y9", Base36.Encode(1233L));
            Assert.AreEqual("YA", Base36.Encode(1234L));
            Assert.AreEqual("YB", Base36.Encode(1235L));
            Assert.AreEqual("YC", Base36.Encode(1236L));
            Assert.AreEqual("YD", Base36.Encode(1237L));
            Assert.AreEqual("YE", Base36.Encode(1238L));
            Assert.AreEqual("YF", Base36.Encode(1239L));
            Assert.AreEqual("YG", Base36.Encode(1240L));
            Assert.AreEqual("YH", Base36.Encode(1241L));
            Assert.AreEqual("YI", Base36.Encode(1242L));
            Assert.AreEqual("YJ", Base36.Encode(1243L));
            Assert.AreEqual("YK", Base36.Encode(1244L));
            Assert.AreEqual("YL", Base36.Encode(1245L));
            Assert.AreEqual("YM", Base36.Encode(1246L));
            Assert.AreEqual("YN", Base36.Encode(1247L));
            Assert.AreEqual("YO", Base36.Encode(1248L));
            Assert.AreEqual("YP", Base36.Encode(1249L));
            Assert.AreEqual("YQ", Base36.Encode(1250L));
            Assert.AreEqual("YR", Base36.Encode(1251L));
            Assert.AreEqual("YS", Base36.Encode(1252L));
            Assert.AreEqual("YT", Base36.Encode(1253L));
            Assert.AreEqual("YU", Base36.Encode(1254L));
            Assert.AreEqual("YV", Base36.Encode(1255L));
            Assert.AreEqual("YW", Base36.Encode(1256L));
            Assert.AreEqual("YX", Base36.Encode(1257L));
            Assert.AreEqual("YY", Base36.Encode(1258L));
            Assert.AreEqual("YZ", Base36.Encode(1259L));

            #endregion

            #region Z0 to ZZ

            Assert.AreEqual("Z0", Base36.Encode(1260L));
            Assert.AreEqual("Z1", Base36.Encode(1261L));
            Assert.AreEqual("Z2", Base36.Encode(1262L));
            Assert.AreEqual("Z3", Base36.Encode(1263L));
            Assert.AreEqual("Z4", Base36.Encode(1264L));
            Assert.AreEqual("Z5", Base36.Encode(1265L));
            Assert.AreEqual("Z6", Base36.Encode(1266L));
            Assert.AreEqual("Z7", Base36.Encode(1267L));
            Assert.AreEqual("Z8", Base36.Encode(1268L));
            Assert.AreEqual("Z9", Base36.Encode(1269L));
            Assert.AreEqual("ZA", Base36.Encode(1270L));
            Assert.AreEqual("ZB", Base36.Encode(1271L));
            Assert.AreEqual("ZC", Base36.Encode(1272L));
            Assert.AreEqual("ZD", Base36.Encode(1273L));
            Assert.AreEqual("ZE", Base36.Encode(1274L));
            Assert.AreEqual("ZF", Base36.Encode(1275L));
            Assert.AreEqual("ZG", Base36.Encode(1276L));
            Assert.AreEqual("ZH", Base36.Encode(1277L));
            Assert.AreEqual("ZI", Base36.Encode(1278L));
            Assert.AreEqual("ZJ", Base36.Encode(1279L));
            Assert.AreEqual("ZK", Base36.Encode(1280L));
            Assert.AreEqual("ZL", Base36.Encode(1281L));
            Assert.AreEqual("ZM", Base36.Encode(1282L));
            Assert.AreEqual("ZN", Base36.Encode(1283L));
            Assert.AreEqual("ZO", Base36.Encode(1284L));
            Assert.AreEqual("ZP", Base36.Encode(1285L));
            Assert.AreEqual("ZQ", Base36.Encode(1286L));
            Assert.AreEqual("ZR", Base36.Encode(1287L));
            Assert.AreEqual("ZS", Base36.Encode(1288L));
            Assert.AreEqual("ZT", Base36.Encode(1289L));
            Assert.AreEqual("ZU", Base36.Encode(1290L));
            Assert.AreEqual("ZV", Base36.Encode(1291L));
            Assert.AreEqual("ZW", Base36.Encode(1292L));
            Assert.AreEqual("ZX", Base36.Encode(1293L));
            Assert.AreEqual("ZY", Base36.Encode(1294L));
            Assert.AreEqual("ZZ", Base36.Encode(1295L));

            #endregion
        }
    }
}
