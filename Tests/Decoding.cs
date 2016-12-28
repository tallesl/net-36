namespace Base36Library.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Decoding
    {
        [TestMethod]
        public void Zeroes()
        {
            Assert.AreEqual(0, Base36.Decode("0"));
            Assert.AreEqual(0, Base36.Decode("00"));
            Assert.AreEqual(0, Base36.Decode("000"));

            Assert.AreEqual(0, Base36.Decode("-0"));
            Assert.AreEqual(0, Base36.Decode("-00"));
            Assert.AreEqual(0, Base36.Decode("-000"));

            Assert.AreEqual(1, Base36.Decode("01"));
            Assert.AreEqual(1, Base36.Decode("001"));
            Assert.AreEqual(1, Base36.Decode("001"));

            Assert.AreEqual(-1, Base36.Decode("-01"));
            Assert.AreEqual(-1, Base36.Decode("-001"));
            Assert.AreEqual(-1, Base36.Decode("-001"));
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Null()
        {
            Base36.Decode(null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Empty()
        {
            Base36.Decode(string.Empty);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Invalid()
        {
            Base36.Decode("invali d");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PositiveOverflow()
        {
            Base36.Decode("1Y2P0IJ32E8E8");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NegativeOverflow()
        {
            Base36.Decode("-1Y2P0IJ32E8E9");
        }

        [TestMethod]
        public void Negative()
        {
            Assert.AreEqual(-13330L, Base36.Decode("-AAA"));
            Assert.AreEqual(-1833836359370, Base36.Decode("-NEGATIVE"));
        }

        [TestMethod]
        public void MixedCases()
        {
            Assert.AreEqual(Base36.Decode("aaa"), Base36.Decode("AAA"));
            Assert.AreEqual(Base36.Decode("AaA"), Base36.Decode("aAa"));
            Assert.AreEqual(Base36.Decode("test"), Base36.Decode("TEST"));
            Assert.AreEqual(Base36.Decode("tESt"), Base36.Decode("tESt"));
        }

        [TestMethod]
        public void MultiplesOf10()
        {
            Assert.AreEqual(10L, Base36.Decode("A"));
            Assert.AreEqual(100L, Base36.Decode("2S"));
            Assert.AreEqual(1000L, Base36.Decode("RS"));
            Assert.AreEqual(10000L, Base36.Decode("7PS"));
            Assert.AreEqual(100000L, Base36.Decode("255S"));
            Assert.AreEqual(1000000L, Base36.Decode("LFLS"));
            Assert.AreEqual(10000000L, Base36.Decode("5YC1S"));
            Assert.AreEqual(100000000L, Base36.Decode("1NJCHS"));
            Assert.AreEqual(1000000000L, Base36.Decode("GJDGXS"));
            Assert.AreEqual(10000000000L, Base36.Decode("4LDQPDS"));
            Assert.AreEqual(100000000000L, Base36.Decode("19XTF1TS"));
            Assert.AreEqual(1000000000000L, Base36.Decode("CRE66I9S"));
            Assert.AreEqual(10000000000000L, Base36.Decode("3JLXPT2PS"));
            Assert.AreEqual(100000000000000L, Base36.Decode("ZG3D62R5S"));
            Assert.AreEqual(1000000000000000L, Base36.Decode("9UGXNORJLS"));
            Assert.AreEqual(10000000000000000L, Base36.Decode("2QGPCKVNG1S"));
            Assert.AreEqual(100000000000000000L, Base36.Decode("RCN1HSSIGHS"));
            Assert.AreEqual(1000000000000000000L, Base36.Decode("7LIEEXZX4KXS"));
        }

        [TestMethod]
        public void MultiplesOf36()
        {
            Assert.AreEqual(36L, Base36.Decode("10"));
            Assert.AreEqual(1296L, Base36.Decode("100"));
            Assert.AreEqual(46656L, Base36.Decode("1000"));
            Assert.AreEqual(1679616L, Base36.Decode("10000"));
            Assert.AreEqual(60466176L, Base36.Decode("100000"));
            Assert.AreEqual(2176782336L, Base36.Decode("1000000"));
            Assert.AreEqual(78364164096L, Base36.Decode("10000000"));
            Assert.AreEqual(2821109907456L, Base36.Decode("100000000"));
            Assert.AreEqual(101559956668416L, Base36.Decode("1000000000"));
            Assert.AreEqual(3656158440062976L, Base36.Decode("10000000000"));
            Assert.AreEqual(131621703842267136L, Base36.Decode("100000000000"));
        }

        [TestMethod]
        public void LongMinValue()
        {
            Assert.AreEqual(long.MinValue, Base36.Decode("-1Y2P0IJ32E8E8"));
        }

        [TestMethod]
        public void LongMaxValue()
        {
            Assert.AreEqual(long.MaxValue, Base36.Decode("1Y2P0IJ32E8E7"));
        }

        [TestMethod]
        public void SingleDigits()
        {
            #region 0 to Z

            Assert.AreEqual(0L, Base36.Decode("0"));
            Assert.AreEqual(1L, Base36.Decode("1"));
            Assert.AreEqual(2L, Base36.Decode("2"));
            Assert.AreEqual(3L, Base36.Decode("3"));
            Assert.AreEqual(4L, Base36.Decode("4"));
            Assert.AreEqual(5L, Base36.Decode("5"));
            Assert.AreEqual(6L, Base36.Decode("6"));
            Assert.AreEqual(7L, Base36.Decode("7"));
            Assert.AreEqual(8L, Base36.Decode("8"));
            Assert.AreEqual(9L, Base36.Decode("9"));
            Assert.AreEqual(10L, Base36.Decode("A"));
            Assert.AreEqual(11L, Base36.Decode("B"));
            Assert.AreEqual(12L, Base36.Decode("C"));
            Assert.AreEqual(13L, Base36.Decode("D"));
            Assert.AreEqual(14L, Base36.Decode("E"));
            Assert.AreEqual(15L, Base36.Decode("F"));
            Assert.AreEqual(16L, Base36.Decode("G"));
            Assert.AreEqual(17L, Base36.Decode("H"));
            Assert.AreEqual(18L, Base36.Decode("I"));
            Assert.AreEqual(19L, Base36.Decode("J"));
            Assert.AreEqual(20L, Base36.Decode("K"));
            Assert.AreEqual(21L, Base36.Decode("L"));
            Assert.AreEqual(22L, Base36.Decode("M"));
            Assert.AreEqual(23L, Base36.Decode("N"));
            Assert.AreEqual(24L, Base36.Decode("O"));
            Assert.AreEqual(25L, Base36.Decode("P"));
            Assert.AreEqual(26L, Base36.Decode("Q"));
            Assert.AreEqual(27L, Base36.Decode("R"));
            Assert.AreEqual(28L, Base36.Decode("S"));
            Assert.AreEqual(29L, Base36.Decode("T"));
            Assert.AreEqual(30L, Base36.Decode("U"));
            Assert.AreEqual(31L, Base36.Decode("V"));
            Assert.AreEqual(32L, Base36.Decode("W"));
            Assert.AreEqual(33L, Base36.Decode("X"));
            Assert.AreEqual(34L, Base36.Decode("Y"));
            Assert.AreEqual(35L, Base36.Decode("Z"));

            #endregion
        }

        [TestMethod]
        public void DoubleDigits()
        {
            #region 10 to 1Z

            Assert.AreEqual(36L, Base36.Decode("10"));
            Assert.AreEqual(37L, Base36.Decode("11"));
            Assert.AreEqual(38L, Base36.Decode("12"));
            Assert.AreEqual(39L, Base36.Decode("13"));
            Assert.AreEqual(40L, Base36.Decode("14"));
            Assert.AreEqual(41L, Base36.Decode("15"));
            Assert.AreEqual(42L, Base36.Decode("16"));
            Assert.AreEqual(43L, Base36.Decode("17"));
            Assert.AreEqual(44L, Base36.Decode("18"));
            Assert.AreEqual(45L, Base36.Decode("19"));
            Assert.AreEqual(46L, Base36.Decode("1A"));
            Assert.AreEqual(47L, Base36.Decode("1B"));
            Assert.AreEqual(48L, Base36.Decode("1C"));
            Assert.AreEqual(49L, Base36.Decode("1D"));
            Assert.AreEqual(50L, Base36.Decode("1E"));
            Assert.AreEqual(51L, Base36.Decode("1F"));
            Assert.AreEqual(52L, Base36.Decode("1G"));
            Assert.AreEqual(53L, Base36.Decode("1H"));
            Assert.AreEqual(54L, Base36.Decode("1I"));
            Assert.AreEqual(55L, Base36.Decode("1J"));
            Assert.AreEqual(56L, Base36.Decode("1K"));
            Assert.AreEqual(57L, Base36.Decode("1L"));
            Assert.AreEqual(58L, Base36.Decode("1M"));
            Assert.AreEqual(59L, Base36.Decode("1N"));
            Assert.AreEqual(60L, Base36.Decode("1O"));
            Assert.AreEqual(61L, Base36.Decode("1P"));
            Assert.AreEqual(62L, Base36.Decode("1Q"));
            Assert.AreEqual(63L, Base36.Decode("1R"));
            Assert.AreEqual(64L, Base36.Decode("1S"));
            Assert.AreEqual(65L, Base36.Decode("1T"));
            Assert.AreEqual(66L, Base36.Decode("1U"));
            Assert.AreEqual(67L, Base36.Decode("1V"));
            Assert.AreEqual(68L, Base36.Decode("1W"));
            Assert.AreEqual(69L, Base36.Decode("1X"));
            Assert.AreEqual(70L, Base36.Decode("1Y"));
            Assert.AreEqual(71L, Base36.Decode("1Z"));

            #endregion

            #region 20 to 2Z

            Assert.AreEqual(72L, Base36.Decode("20"));
            Assert.AreEqual(73L, Base36.Decode("21"));
            Assert.AreEqual(74L, Base36.Decode("22"));
            Assert.AreEqual(75L, Base36.Decode("23"));
            Assert.AreEqual(76L, Base36.Decode("24"));
            Assert.AreEqual(77L, Base36.Decode("25"));
            Assert.AreEqual(78L, Base36.Decode("26"));
            Assert.AreEqual(79L, Base36.Decode("27"));
            Assert.AreEqual(80L, Base36.Decode("28"));
            Assert.AreEqual(81L, Base36.Decode("29"));
            Assert.AreEqual(82L, Base36.Decode("2A"));
            Assert.AreEqual(83L, Base36.Decode("2B"));
            Assert.AreEqual(84L, Base36.Decode("2C"));
            Assert.AreEqual(85L, Base36.Decode("2D"));
            Assert.AreEqual(86L, Base36.Decode("2E"));
            Assert.AreEqual(87L, Base36.Decode("2F"));
            Assert.AreEqual(88L, Base36.Decode("2G"));
            Assert.AreEqual(89L, Base36.Decode("2H"));
            Assert.AreEqual(90L, Base36.Decode("2I"));
            Assert.AreEqual(91L, Base36.Decode("2J"));
            Assert.AreEqual(92L, Base36.Decode("2K"));
            Assert.AreEqual(93L, Base36.Decode("2L"));
            Assert.AreEqual(94L, Base36.Decode("2M"));
            Assert.AreEqual(95L, Base36.Decode("2N"));
            Assert.AreEqual(96L, Base36.Decode("2O"));
            Assert.AreEqual(97L, Base36.Decode("2P"));
            Assert.AreEqual(98L, Base36.Decode("2Q"));
            Assert.AreEqual(99L, Base36.Decode("2R"));
            Assert.AreEqual(100L, Base36.Decode("2S"));
            Assert.AreEqual(101L, Base36.Decode("2T"));
            Assert.AreEqual(102L, Base36.Decode("2U"));
            Assert.AreEqual(103L, Base36.Decode("2V"));
            Assert.AreEqual(104L, Base36.Decode("2W"));
            Assert.AreEqual(105L, Base36.Decode("2X"));
            Assert.AreEqual(106L, Base36.Decode("2Y"));
            Assert.AreEqual(107L, Base36.Decode("2Z"));

            #endregion

            #region 30 to 3Z

            Assert.AreEqual(108L, Base36.Decode("30"));
            Assert.AreEqual(109L, Base36.Decode("31"));
            Assert.AreEqual(110L, Base36.Decode("32"));
            Assert.AreEqual(111L, Base36.Decode("33"));
            Assert.AreEqual(112L, Base36.Decode("34"));
            Assert.AreEqual(113L, Base36.Decode("35"));
            Assert.AreEqual(114L, Base36.Decode("36"));
            Assert.AreEqual(115L, Base36.Decode("37"));
            Assert.AreEqual(116L, Base36.Decode("38"));
            Assert.AreEqual(117L, Base36.Decode("39"));
            Assert.AreEqual(118L, Base36.Decode("3A"));
            Assert.AreEqual(119L, Base36.Decode("3B"));
            Assert.AreEqual(120L, Base36.Decode("3C"));
            Assert.AreEqual(121L, Base36.Decode("3D"));
            Assert.AreEqual(122L, Base36.Decode("3E"));
            Assert.AreEqual(123L, Base36.Decode("3F"));
            Assert.AreEqual(124L, Base36.Decode("3G"));
            Assert.AreEqual(125L, Base36.Decode("3H"));
            Assert.AreEqual(126L, Base36.Decode("3I"));
            Assert.AreEqual(127L, Base36.Decode("3J"));
            Assert.AreEqual(128L, Base36.Decode("3K"));
            Assert.AreEqual(129L, Base36.Decode("3L"));
            Assert.AreEqual(130L, Base36.Decode("3M"));
            Assert.AreEqual(131L, Base36.Decode("3N"));
            Assert.AreEqual(132L, Base36.Decode("3O"));
            Assert.AreEqual(133L, Base36.Decode("3P"));
            Assert.AreEqual(134L, Base36.Decode("3Q"));
            Assert.AreEqual(135L, Base36.Decode("3R"));
            Assert.AreEqual(136L, Base36.Decode("3S"));
            Assert.AreEqual(137L, Base36.Decode("3T"));
            Assert.AreEqual(138L, Base36.Decode("3U"));
            Assert.AreEqual(139L, Base36.Decode("3V"));
            Assert.AreEqual(140L, Base36.Decode("3W"));
            Assert.AreEqual(141L, Base36.Decode("3X"));
            Assert.AreEqual(142L, Base36.Decode("3Y"));
            Assert.AreEqual(143L, Base36.Decode("3Z"));

            #endregion

            #region 40 to 4Z

            Assert.AreEqual(144L, Base36.Decode("40"));
            Assert.AreEqual(145L, Base36.Decode("41"));
            Assert.AreEqual(146L, Base36.Decode("42"));
            Assert.AreEqual(147L, Base36.Decode("43"));
            Assert.AreEqual(148L, Base36.Decode("44"));
            Assert.AreEqual(149L, Base36.Decode("45"));
            Assert.AreEqual(150L, Base36.Decode("46"));
            Assert.AreEqual(151L, Base36.Decode("47"));
            Assert.AreEqual(152L, Base36.Decode("48"));
            Assert.AreEqual(153L, Base36.Decode("49"));
            Assert.AreEqual(154L, Base36.Decode("4A"));
            Assert.AreEqual(155L, Base36.Decode("4B"));
            Assert.AreEqual(156L, Base36.Decode("4C"));
            Assert.AreEqual(157L, Base36.Decode("4D"));
            Assert.AreEqual(158L, Base36.Decode("4E"));
            Assert.AreEqual(159L, Base36.Decode("4F"));
            Assert.AreEqual(160L, Base36.Decode("4G"));
            Assert.AreEqual(161L, Base36.Decode("4H"));
            Assert.AreEqual(162L, Base36.Decode("4I"));
            Assert.AreEqual(163L, Base36.Decode("4J"));
            Assert.AreEqual(164L, Base36.Decode("4K"));
            Assert.AreEqual(165L, Base36.Decode("4L"));
            Assert.AreEqual(166L, Base36.Decode("4M"));
            Assert.AreEqual(167L, Base36.Decode("4N"));
            Assert.AreEqual(168L, Base36.Decode("4O"));
            Assert.AreEqual(169L, Base36.Decode("4P"));
            Assert.AreEqual(170L, Base36.Decode("4Q"));
            Assert.AreEqual(171L, Base36.Decode("4R"));
            Assert.AreEqual(172L, Base36.Decode("4S"));
            Assert.AreEqual(173L, Base36.Decode("4T"));
            Assert.AreEqual(174L, Base36.Decode("4U"));
            Assert.AreEqual(175L, Base36.Decode("4V"));
            Assert.AreEqual(176L, Base36.Decode("4W"));
            Assert.AreEqual(177L, Base36.Decode("4X"));
            Assert.AreEqual(178L, Base36.Decode("4Y"));
            Assert.AreEqual(179L, Base36.Decode("4Z"));

            #endregion

            #region 50 to 5Z

            Assert.AreEqual(180L, Base36.Decode("50"));
            Assert.AreEqual(181L, Base36.Decode("51"));
            Assert.AreEqual(182L, Base36.Decode("52"));
            Assert.AreEqual(183L, Base36.Decode("53"));
            Assert.AreEqual(184L, Base36.Decode("54"));
            Assert.AreEqual(185L, Base36.Decode("55"));
            Assert.AreEqual(186L, Base36.Decode("56"));
            Assert.AreEqual(187L, Base36.Decode("57"));
            Assert.AreEqual(188L, Base36.Decode("58"));
            Assert.AreEqual(189L, Base36.Decode("59"));
            Assert.AreEqual(190L, Base36.Decode("5A"));
            Assert.AreEqual(191L, Base36.Decode("5B"));
            Assert.AreEqual(192L, Base36.Decode("5C"));
            Assert.AreEqual(193L, Base36.Decode("5D"));
            Assert.AreEqual(194L, Base36.Decode("5E"));
            Assert.AreEqual(195L, Base36.Decode("5F"));
            Assert.AreEqual(196L, Base36.Decode("5G"));
            Assert.AreEqual(197L, Base36.Decode("5H"));
            Assert.AreEqual(198L, Base36.Decode("5I"));
            Assert.AreEqual(199L, Base36.Decode("5J"));
            Assert.AreEqual(200L, Base36.Decode("5K"));
            Assert.AreEqual(201L, Base36.Decode("5L"));
            Assert.AreEqual(202L, Base36.Decode("5M"));
            Assert.AreEqual(203L, Base36.Decode("5N"));
            Assert.AreEqual(204L, Base36.Decode("5O"));
            Assert.AreEqual(205L, Base36.Decode("5P"));
            Assert.AreEqual(206L, Base36.Decode("5Q"));
            Assert.AreEqual(207L, Base36.Decode("5R"));
            Assert.AreEqual(208L, Base36.Decode("5S"));
            Assert.AreEqual(209L, Base36.Decode("5T"));
            Assert.AreEqual(210L, Base36.Decode("5U"));
            Assert.AreEqual(211L, Base36.Decode("5V"));
            Assert.AreEqual(212L, Base36.Decode("5W"));
            Assert.AreEqual(213L, Base36.Decode("5X"));
            Assert.AreEqual(214L, Base36.Decode("5Y"));
            Assert.AreEqual(215L, Base36.Decode("5Z"));

            #endregion

            #region 60 to 6Z

            Assert.AreEqual(216L, Base36.Decode("60"));
            Assert.AreEqual(217L, Base36.Decode("61"));
            Assert.AreEqual(218L, Base36.Decode("62"));
            Assert.AreEqual(219L, Base36.Decode("63"));
            Assert.AreEqual(220L, Base36.Decode("64"));
            Assert.AreEqual(221L, Base36.Decode("65"));
            Assert.AreEqual(222L, Base36.Decode("66"));
            Assert.AreEqual(223L, Base36.Decode("67"));
            Assert.AreEqual(224L, Base36.Decode("68"));
            Assert.AreEqual(225L, Base36.Decode("69"));
            Assert.AreEqual(226L, Base36.Decode("6A"));
            Assert.AreEqual(227L, Base36.Decode("6B"));
            Assert.AreEqual(228L, Base36.Decode("6C"));
            Assert.AreEqual(229L, Base36.Decode("6D"));
            Assert.AreEqual(230L, Base36.Decode("6E"));
            Assert.AreEqual(231L, Base36.Decode("6F"));
            Assert.AreEqual(232L, Base36.Decode("6G"));
            Assert.AreEqual(233L, Base36.Decode("6H"));
            Assert.AreEqual(234L, Base36.Decode("6I"));
            Assert.AreEqual(235L, Base36.Decode("6J"));
            Assert.AreEqual(236L, Base36.Decode("6K"));
            Assert.AreEqual(237L, Base36.Decode("6L"));
            Assert.AreEqual(238L, Base36.Decode("6M"));
            Assert.AreEqual(239L, Base36.Decode("6N"));
            Assert.AreEqual(240L, Base36.Decode("6O"));
            Assert.AreEqual(241L, Base36.Decode("6P"));
            Assert.AreEqual(242L, Base36.Decode("6Q"));
            Assert.AreEqual(243L, Base36.Decode("6R"));
            Assert.AreEqual(244L, Base36.Decode("6S"));
            Assert.AreEqual(245L, Base36.Decode("6T"));
            Assert.AreEqual(246L, Base36.Decode("6U"));
            Assert.AreEqual(247L, Base36.Decode("6V"));
            Assert.AreEqual(248L, Base36.Decode("6W"));
            Assert.AreEqual(249L, Base36.Decode("6X"));
            Assert.AreEqual(250L, Base36.Decode("6Y"));
            Assert.AreEqual(251L, Base36.Decode("6Z"));

            #endregion

            #region 70 to 7Z

            Assert.AreEqual(252L, Base36.Decode("70"));
            Assert.AreEqual(253L, Base36.Decode("71"));
            Assert.AreEqual(254L, Base36.Decode("72"));
            Assert.AreEqual(255L, Base36.Decode("73"));
            Assert.AreEqual(256L, Base36.Decode("74"));
            Assert.AreEqual(257L, Base36.Decode("75"));
            Assert.AreEqual(258L, Base36.Decode("76"));
            Assert.AreEqual(259L, Base36.Decode("77"));
            Assert.AreEqual(260L, Base36.Decode("78"));
            Assert.AreEqual(261L, Base36.Decode("79"));
            Assert.AreEqual(262L, Base36.Decode("7A"));
            Assert.AreEqual(263L, Base36.Decode("7B"));
            Assert.AreEqual(264L, Base36.Decode("7C"));
            Assert.AreEqual(265L, Base36.Decode("7D"));
            Assert.AreEqual(266L, Base36.Decode("7E"));
            Assert.AreEqual(267L, Base36.Decode("7F"));
            Assert.AreEqual(268L, Base36.Decode("7G"));
            Assert.AreEqual(269L, Base36.Decode("7H"));
            Assert.AreEqual(270L, Base36.Decode("7I"));
            Assert.AreEqual(271L, Base36.Decode("7J"));
            Assert.AreEqual(272L, Base36.Decode("7K"));
            Assert.AreEqual(273L, Base36.Decode("7L"));
            Assert.AreEqual(274L, Base36.Decode("7M"));
            Assert.AreEqual(275L, Base36.Decode("7N"));
            Assert.AreEqual(276L, Base36.Decode("7O"));
            Assert.AreEqual(277L, Base36.Decode("7P"));
            Assert.AreEqual(278L, Base36.Decode("7Q"));
            Assert.AreEqual(279L, Base36.Decode("7R"));
            Assert.AreEqual(280L, Base36.Decode("7S"));
            Assert.AreEqual(281L, Base36.Decode("7T"));
            Assert.AreEqual(282L, Base36.Decode("7U"));
            Assert.AreEqual(283L, Base36.Decode("7V"));
            Assert.AreEqual(284L, Base36.Decode("7W"));
            Assert.AreEqual(285L, Base36.Decode("7X"));
            Assert.AreEqual(286L, Base36.Decode("7Y"));
            Assert.AreEqual(287L, Base36.Decode("7Z"));

            #endregion

            #region 80 to 8Z

            Assert.AreEqual(288L, Base36.Decode("80"));
            Assert.AreEqual(289L, Base36.Decode("81"));
            Assert.AreEqual(290L, Base36.Decode("82"));
            Assert.AreEqual(291L, Base36.Decode("83"));
            Assert.AreEqual(292L, Base36.Decode("84"));
            Assert.AreEqual(293L, Base36.Decode("85"));
            Assert.AreEqual(294L, Base36.Decode("86"));
            Assert.AreEqual(295L, Base36.Decode("87"));
            Assert.AreEqual(296L, Base36.Decode("88"));
            Assert.AreEqual(297L, Base36.Decode("89"));
            Assert.AreEqual(298L, Base36.Decode("8A"));
            Assert.AreEqual(299L, Base36.Decode("8B"));
            Assert.AreEqual(300L, Base36.Decode("8C"));
            Assert.AreEqual(301L, Base36.Decode("8D"));
            Assert.AreEqual(302L, Base36.Decode("8E"));
            Assert.AreEqual(303L, Base36.Decode("8F"));
            Assert.AreEqual(304L, Base36.Decode("8G"));
            Assert.AreEqual(305L, Base36.Decode("8H"));
            Assert.AreEqual(306L, Base36.Decode("8I"));
            Assert.AreEqual(307L, Base36.Decode("8J"));
            Assert.AreEqual(308L, Base36.Decode("8K"));
            Assert.AreEqual(309L, Base36.Decode("8L"));
            Assert.AreEqual(310L, Base36.Decode("8M"));
            Assert.AreEqual(311L, Base36.Decode("8N"));
            Assert.AreEqual(312L, Base36.Decode("8O"));
            Assert.AreEqual(313L, Base36.Decode("8P"));
            Assert.AreEqual(314L, Base36.Decode("8Q"));
            Assert.AreEqual(315L, Base36.Decode("8R"));
            Assert.AreEqual(316L, Base36.Decode("8S"));
            Assert.AreEqual(317L, Base36.Decode("8T"));
            Assert.AreEqual(318L, Base36.Decode("8U"));
            Assert.AreEqual(319L, Base36.Decode("8V"));
            Assert.AreEqual(320L, Base36.Decode("8W"));
            Assert.AreEqual(321L, Base36.Decode("8X"));
            Assert.AreEqual(322L, Base36.Decode("8Y"));
            Assert.AreEqual(323L, Base36.Decode("8Z"));

            #endregion

            #region 90 to 9Z

            Assert.AreEqual(324L, Base36.Decode("90"));
            Assert.AreEqual(325L, Base36.Decode("91"));
            Assert.AreEqual(326L, Base36.Decode("92"));
            Assert.AreEqual(327L, Base36.Decode("93"));
            Assert.AreEqual(328L, Base36.Decode("94"));
            Assert.AreEqual(329L, Base36.Decode("95"));
            Assert.AreEqual(330L, Base36.Decode("96"));
            Assert.AreEqual(331L, Base36.Decode("97"));
            Assert.AreEqual(332L, Base36.Decode("98"));
            Assert.AreEqual(333L, Base36.Decode("99"));
            Assert.AreEqual(334L, Base36.Decode("9A"));
            Assert.AreEqual(335L, Base36.Decode("9B"));
            Assert.AreEqual(336L, Base36.Decode("9C"));
            Assert.AreEqual(337L, Base36.Decode("9D"));
            Assert.AreEqual(338L, Base36.Decode("9E"));
            Assert.AreEqual(339L, Base36.Decode("9F"));
            Assert.AreEqual(340L, Base36.Decode("9G"));
            Assert.AreEqual(341L, Base36.Decode("9H"));
            Assert.AreEqual(342L, Base36.Decode("9I"));
            Assert.AreEqual(343L, Base36.Decode("9J"));
            Assert.AreEqual(344L, Base36.Decode("9K"));
            Assert.AreEqual(345L, Base36.Decode("9L"));
            Assert.AreEqual(346L, Base36.Decode("9M"));
            Assert.AreEqual(347L, Base36.Decode("9N"));
            Assert.AreEqual(348L, Base36.Decode("9O"));
            Assert.AreEqual(349L, Base36.Decode("9P"));
            Assert.AreEqual(350L, Base36.Decode("9Q"));
            Assert.AreEqual(351L, Base36.Decode("9R"));
            Assert.AreEqual(352L, Base36.Decode("9S"));
            Assert.AreEqual(353L, Base36.Decode("9T"));
            Assert.AreEqual(354L, Base36.Decode("9U"));
            Assert.AreEqual(355L, Base36.Decode("9V"));
            Assert.AreEqual(356L, Base36.Decode("9W"));
            Assert.AreEqual(357L, Base36.Decode("9X"));
            Assert.AreEqual(358L, Base36.Decode("9Y"));
            Assert.AreEqual(359L, Base36.Decode("9Z"));

            #endregion

            #region A0 to AZ

            Assert.AreEqual(360L, Base36.Decode("A0"));
            Assert.AreEqual(361L, Base36.Decode("A1"));
            Assert.AreEqual(362L, Base36.Decode("A2"));
            Assert.AreEqual(363L, Base36.Decode("A3"));
            Assert.AreEqual(364L, Base36.Decode("A4"));
            Assert.AreEqual(365L, Base36.Decode("A5"));
            Assert.AreEqual(366L, Base36.Decode("A6"));
            Assert.AreEqual(367L, Base36.Decode("A7"));
            Assert.AreEqual(368L, Base36.Decode("A8"));
            Assert.AreEqual(369L, Base36.Decode("A9"));
            Assert.AreEqual(370L, Base36.Decode("AA"));
            Assert.AreEqual(371L, Base36.Decode("AB"));
            Assert.AreEqual(372L, Base36.Decode("AC"));
            Assert.AreEqual(373L, Base36.Decode("AD"));
            Assert.AreEqual(374L, Base36.Decode("AE"));
            Assert.AreEqual(375L, Base36.Decode("AF"));
            Assert.AreEqual(376L, Base36.Decode("AG"));
            Assert.AreEqual(377L, Base36.Decode("AH"));
            Assert.AreEqual(378L, Base36.Decode("AI"));
            Assert.AreEqual(379L, Base36.Decode("AJ"));
            Assert.AreEqual(380L, Base36.Decode("AK"));
            Assert.AreEqual(381L, Base36.Decode("AL"));
            Assert.AreEqual(382L, Base36.Decode("AM"));
            Assert.AreEqual(383L, Base36.Decode("AN"));
            Assert.AreEqual(384L, Base36.Decode("AO"));
            Assert.AreEqual(385L, Base36.Decode("AP"));
            Assert.AreEqual(386L, Base36.Decode("AQ"));
            Assert.AreEqual(387L, Base36.Decode("AR"));
            Assert.AreEqual(388L, Base36.Decode("AS"));
            Assert.AreEqual(389L, Base36.Decode("AT"));
            Assert.AreEqual(390L, Base36.Decode("AU"));
            Assert.AreEqual(391L, Base36.Decode("AV"));
            Assert.AreEqual(392L, Base36.Decode("AW"));
            Assert.AreEqual(393L, Base36.Decode("AX"));
            Assert.AreEqual(394L, Base36.Decode("AY"));
            Assert.AreEqual(395L, Base36.Decode("AZ"));

            #endregion

            #region B0 to BZ

            Assert.AreEqual(396L, Base36.Decode("B0"));
            Assert.AreEqual(397L, Base36.Decode("B1"));
            Assert.AreEqual(398L, Base36.Decode("B2"));
            Assert.AreEqual(399L, Base36.Decode("B3"));
            Assert.AreEqual(400L, Base36.Decode("B4"));
            Assert.AreEqual(401L, Base36.Decode("B5"));
            Assert.AreEqual(402L, Base36.Decode("B6"));
            Assert.AreEqual(403L, Base36.Decode("B7"));
            Assert.AreEqual(404L, Base36.Decode("B8"));
            Assert.AreEqual(405L, Base36.Decode("B9"));
            Assert.AreEqual(406L, Base36.Decode("BA"));
            Assert.AreEqual(407L, Base36.Decode("BB"));
            Assert.AreEqual(408L, Base36.Decode("BC"));
            Assert.AreEqual(409L, Base36.Decode("BD"));
            Assert.AreEqual(410L, Base36.Decode("BE"));
            Assert.AreEqual(411L, Base36.Decode("BF"));
            Assert.AreEqual(412L, Base36.Decode("BG"));
            Assert.AreEqual(413L, Base36.Decode("BH"));
            Assert.AreEqual(414L, Base36.Decode("BI"));
            Assert.AreEqual(415L, Base36.Decode("BJ"));
            Assert.AreEqual(416L, Base36.Decode("BK"));
            Assert.AreEqual(417L, Base36.Decode("BL"));
            Assert.AreEqual(418L, Base36.Decode("BM"));
            Assert.AreEqual(419L, Base36.Decode("BN"));
            Assert.AreEqual(420L, Base36.Decode("BO"));
            Assert.AreEqual(421L, Base36.Decode("BP"));
            Assert.AreEqual(422L, Base36.Decode("BQ"));
            Assert.AreEqual(423L, Base36.Decode("BR"));
            Assert.AreEqual(424L, Base36.Decode("BS"));
            Assert.AreEqual(425L, Base36.Decode("BT"));
            Assert.AreEqual(426L, Base36.Decode("BU"));
            Assert.AreEqual(427L, Base36.Decode("BV"));
            Assert.AreEqual(428L, Base36.Decode("BW"));
            Assert.AreEqual(429L, Base36.Decode("BX"));
            Assert.AreEqual(430L, Base36.Decode("BY"));
            Assert.AreEqual(431L, Base36.Decode("BZ"));

            #endregion

            #region C0 to CZ

            Assert.AreEqual(432L, Base36.Decode("C0"));
            Assert.AreEqual(433L, Base36.Decode("C1"));
            Assert.AreEqual(434L, Base36.Decode("C2"));
            Assert.AreEqual(435L, Base36.Decode("C3"));
            Assert.AreEqual(436L, Base36.Decode("C4"));
            Assert.AreEqual(437L, Base36.Decode("C5"));
            Assert.AreEqual(438L, Base36.Decode("C6"));
            Assert.AreEqual(439L, Base36.Decode("C7"));
            Assert.AreEqual(440L, Base36.Decode("C8"));
            Assert.AreEqual(441L, Base36.Decode("C9"));
            Assert.AreEqual(442L, Base36.Decode("CA"));
            Assert.AreEqual(443L, Base36.Decode("CB"));
            Assert.AreEqual(444L, Base36.Decode("CC"));
            Assert.AreEqual(445L, Base36.Decode("CD"));
            Assert.AreEqual(446L, Base36.Decode("CE"));
            Assert.AreEqual(447L, Base36.Decode("CF"));
            Assert.AreEqual(448L, Base36.Decode("CG"));
            Assert.AreEqual(449L, Base36.Decode("CH"));
            Assert.AreEqual(450L, Base36.Decode("CI"));
            Assert.AreEqual(451L, Base36.Decode("CJ"));
            Assert.AreEqual(452L, Base36.Decode("CK"));
            Assert.AreEqual(453L, Base36.Decode("CL"));
            Assert.AreEqual(454L, Base36.Decode("CM"));
            Assert.AreEqual(455L, Base36.Decode("CN"));
            Assert.AreEqual(456L, Base36.Decode("CO"));
            Assert.AreEqual(457L, Base36.Decode("CP"));
            Assert.AreEqual(458L, Base36.Decode("CQ"));
            Assert.AreEqual(459L, Base36.Decode("CR"));
            Assert.AreEqual(460L, Base36.Decode("CS"));
            Assert.AreEqual(461L, Base36.Decode("CT"));
            Assert.AreEqual(462L, Base36.Decode("CU"));
            Assert.AreEqual(463L, Base36.Decode("CV"));
            Assert.AreEqual(464L, Base36.Decode("CW"));
            Assert.AreEqual(465L, Base36.Decode("CX"));
            Assert.AreEqual(466L, Base36.Decode("CY"));
            Assert.AreEqual(467L, Base36.Decode("CZ"));

            #endregion

            #region D0 to DZ

            Assert.AreEqual(468L, Base36.Decode("D0"));
            Assert.AreEqual(469L, Base36.Decode("D1"));
            Assert.AreEqual(470L, Base36.Decode("D2"));
            Assert.AreEqual(471L, Base36.Decode("D3"));
            Assert.AreEqual(472L, Base36.Decode("D4"));
            Assert.AreEqual(473L, Base36.Decode("D5"));
            Assert.AreEqual(474L, Base36.Decode("D6"));
            Assert.AreEqual(475L, Base36.Decode("D7"));
            Assert.AreEqual(476L, Base36.Decode("D8"));
            Assert.AreEqual(477L, Base36.Decode("D9"));
            Assert.AreEqual(478L, Base36.Decode("DA"));
            Assert.AreEqual(479L, Base36.Decode("DB"));
            Assert.AreEqual(480L, Base36.Decode("DC"));
            Assert.AreEqual(481L, Base36.Decode("DD"));
            Assert.AreEqual(482L, Base36.Decode("DE"));
            Assert.AreEqual(483L, Base36.Decode("DF"));
            Assert.AreEqual(484L, Base36.Decode("DG"));
            Assert.AreEqual(485L, Base36.Decode("DH"));
            Assert.AreEqual(486L, Base36.Decode("DI"));
            Assert.AreEqual(487L, Base36.Decode("DJ"));
            Assert.AreEqual(488L, Base36.Decode("DK"));
            Assert.AreEqual(489L, Base36.Decode("DL"));
            Assert.AreEqual(490L, Base36.Decode("DM"));
            Assert.AreEqual(491L, Base36.Decode("DN"));
            Assert.AreEqual(492L, Base36.Decode("DO"));
            Assert.AreEqual(493L, Base36.Decode("DP"));
            Assert.AreEqual(494L, Base36.Decode("DQ"));
            Assert.AreEqual(495L, Base36.Decode("DR"));
            Assert.AreEqual(496L, Base36.Decode("DS"));
            Assert.AreEqual(497L, Base36.Decode("DT"));
            Assert.AreEqual(498L, Base36.Decode("DU"));
            Assert.AreEqual(499L, Base36.Decode("DV"));
            Assert.AreEqual(500L, Base36.Decode("DW"));
            Assert.AreEqual(501L, Base36.Decode("DX"));
            Assert.AreEqual(502L, Base36.Decode("DY"));
            Assert.AreEqual(503L, Base36.Decode("DZ"));

            #endregion

            #region E0 to EZ

            Assert.AreEqual(504L, Base36.Decode("E0"));
            Assert.AreEqual(505L, Base36.Decode("E1"));
            Assert.AreEqual(506L, Base36.Decode("E2"));
            Assert.AreEqual(507L, Base36.Decode("E3"));
            Assert.AreEqual(508L, Base36.Decode("E4"));
            Assert.AreEqual(509L, Base36.Decode("E5"));
            Assert.AreEqual(510L, Base36.Decode("E6"));
            Assert.AreEqual(511L, Base36.Decode("E7"));
            Assert.AreEqual(512L, Base36.Decode("E8"));
            Assert.AreEqual(513L, Base36.Decode("E9"));
            Assert.AreEqual(514L, Base36.Decode("EA"));
            Assert.AreEqual(515L, Base36.Decode("EB"));
            Assert.AreEqual(516L, Base36.Decode("EC"));
            Assert.AreEqual(517L, Base36.Decode("ED"));
            Assert.AreEqual(518L, Base36.Decode("EE"));
            Assert.AreEqual(519L, Base36.Decode("EF"));
            Assert.AreEqual(520L, Base36.Decode("EG"));
            Assert.AreEqual(521L, Base36.Decode("EH"));
            Assert.AreEqual(522L, Base36.Decode("EI"));
            Assert.AreEqual(523L, Base36.Decode("EJ"));
            Assert.AreEqual(524L, Base36.Decode("EK"));
            Assert.AreEqual(525L, Base36.Decode("EL"));
            Assert.AreEqual(526L, Base36.Decode("EM"));
            Assert.AreEqual(527L, Base36.Decode("EN"));
            Assert.AreEqual(528L, Base36.Decode("EO"));
            Assert.AreEqual(529L, Base36.Decode("EP"));
            Assert.AreEqual(530L, Base36.Decode("EQ"));
            Assert.AreEqual(531L, Base36.Decode("ER"));
            Assert.AreEqual(532L, Base36.Decode("ES"));
            Assert.AreEqual(533L, Base36.Decode("ET"));
            Assert.AreEqual(534L, Base36.Decode("EU"));
            Assert.AreEqual(535L, Base36.Decode("EV"));
            Assert.AreEqual(536L, Base36.Decode("EW"));
            Assert.AreEqual(537L, Base36.Decode("EX"));
            Assert.AreEqual(538L, Base36.Decode("EY"));
            Assert.AreEqual(539L, Base36.Decode("EZ"));

            #endregion

            #region F0 to FZ

            Assert.AreEqual(540L, Base36.Decode("F0"));
            Assert.AreEqual(541L, Base36.Decode("F1"));
            Assert.AreEqual(542L, Base36.Decode("F2"));
            Assert.AreEqual(543L, Base36.Decode("F3"));
            Assert.AreEqual(544L, Base36.Decode("F4"));
            Assert.AreEqual(545L, Base36.Decode("F5"));
            Assert.AreEqual(546L, Base36.Decode("F6"));
            Assert.AreEqual(547L, Base36.Decode("F7"));
            Assert.AreEqual(548L, Base36.Decode("F8"));
            Assert.AreEqual(549L, Base36.Decode("F9"));
            Assert.AreEqual(550L, Base36.Decode("FA"));
            Assert.AreEqual(551L, Base36.Decode("FB"));
            Assert.AreEqual(552L, Base36.Decode("FC"));
            Assert.AreEqual(553L, Base36.Decode("FD"));
            Assert.AreEqual(554L, Base36.Decode("FE"));
            Assert.AreEqual(555L, Base36.Decode("FF"));
            Assert.AreEqual(556L, Base36.Decode("FG"));
            Assert.AreEqual(557L, Base36.Decode("FH"));
            Assert.AreEqual(558L, Base36.Decode("FI"));
            Assert.AreEqual(559L, Base36.Decode("FJ"));
            Assert.AreEqual(560L, Base36.Decode("FK"));
            Assert.AreEqual(561L, Base36.Decode("FL"));
            Assert.AreEqual(562L, Base36.Decode("FM"));
            Assert.AreEqual(563L, Base36.Decode("FN"));
            Assert.AreEqual(564L, Base36.Decode("FO"));
            Assert.AreEqual(565L, Base36.Decode("FP"));
            Assert.AreEqual(566L, Base36.Decode("FQ"));
            Assert.AreEqual(567L, Base36.Decode("FR"));
            Assert.AreEqual(568L, Base36.Decode("FS"));
            Assert.AreEqual(569L, Base36.Decode("FT"));
            Assert.AreEqual(570L, Base36.Decode("FU"));
            Assert.AreEqual(571L, Base36.Decode("FV"));
            Assert.AreEqual(572L, Base36.Decode("FW"));
            Assert.AreEqual(573L, Base36.Decode("FX"));
            Assert.AreEqual(574L, Base36.Decode("FY"));
            Assert.AreEqual(575L, Base36.Decode("FZ"));

            #endregion

            #region G0 to GZ

            Assert.AreEqual(576L, Base36.Decode("G0"));
            Assert.AreEqual(577L, Base36.Decode("G1"));
            Assert.AreEqual(578L, Base36.Decode("G2"));
            Assert.AreEqual(579L, Base36.Decode("G3"));
            Assert.AreEqual(580L, Base36.Decode("G4"));
            Assert.AreEqual(581L, Base36.Decode("G5"));
            Assert.AreEqual(582L, Base36.Decode("G6"));
            Assert.AreEqual(583L, Base36.Decode("G7"));
            Assert.AreEqual(584L, Base36.Decode("G8"));
            Assert.AreEqual(585L, Base36.Decode("G9"));
            Assert.AreEqual(586L, Base36.Decode("GA"));
            Assert.AreEqual(587L, Base36.Decode("GB"));
            Assert.AreEqual(588L, Base36.Decode("GC"));
            Assert.AreEqual(589L, Base36.Decode("GD"));
            Assert.AreEqual(590L, Base36.Decode("GE"));
            Assert.AreEqual(591L, Base36.Decode("GF"));
            Assert.AreEqual(592L, Base36.Decode("GG"));
            Assert.AreEqual(593L, Base36.Decode("GH"));
            Assert.AreEqual(594L, Base36.Decode("GI"));
            Assert.AreEqual(595L, Base36.Decode("GJ"));
            Assert.AreEqual(596L, Base36.Decode("GK"));
            Assert.AreEqual(597L, Base36.Decode("GL"));
            Assert.AreEqual(598L, Base36.Decode("GM"));
            Assert.AreEqual(599L, Base36.Decode("GN"));
            Assert.AreEqual(600L, Base36.Decode("GO"));
            Assert.AreEqual(601L, Base36.Decode("GP"));
            Assert.AreEqual(602L, Base36.Decode("GQ"));
            Assert.AreEqual(603L, Base36.Decode("GR"));
            Assert.AreEqual(604L, Base36.Decode("GS"));
            Assert.AreEqual(605L, Base36.Decode("GT"));
            Assert.AreEqual(606L, Base36.Decode("GU"));
            Assert.AreEqual(607L, Base36.Decode("GV"));
            Assert.AreEqual(608L, Base36.Decode("GW"));
            Assert.AreEqual(609L, Base36.Decode("GX"));
            Assert.AreEqual(610L, Base36.Decode("GY"));
            Assert.AreEqual(611L, Base36.Decode("GZ"));

            #endregion

            #region H0 to HZ

            Assert.AreEqual(612L, Base36.Decode("H0"));
            Assert.AreEqual(613L, Base36.Decode("H1"));
            Assert.AreEqual(614L, Base36.Decode("H2"));
            Assert.AreEqual(615L, Base36.Decode("H3"));
            Assert.AreEqual(616L, Base36.Decode("H4"));
            Assert.AreEqual(617L, Base36.Decode("H5"));
            Assert.AreEqual(618L, Base36.Decode("H6"));
            Assert.AreEqual(619L, Base36.Decode("H7"));
            Assert.AreEqual(620L, Base36.Decode("H8"));
            Assert.AreEqual(621L, Base36.Decode("H9"));
            Assert.AreEqual(622L, Base36.Decode("HA"));
            Assert.AreEqual(623L, Base36.Decode("HB"));
            Assert.AreEqual(624L, Base36.Decode("HC"));
            Assert.AreEqual(625L, Base36.Decode("HD"));
            Assert.AreEqual(626L, Base36.Decode("HE"));
            Assert.AreEqual(627L, Base36.Decode("HF"));
            Assert.AreEqual(628L, Base36.Decode("HG"));
            Assert.AreEqual(629L, Base36.Decode("HH"));
            Assert.AreEqual(630L, Base36.Decode("HI"));
            Assert.AreEqual(631L, Base36.Decode("HJ"));
            Assert.AreEqual(632L, Base36.Decode("HK"));
            Assert.AreEqual(633L, Base36.Decode("HL"));
            Assert.AreEqual(634L, Base36.Decode("HM"));
            Assert.AreEqual(635L, Base36.Decode("HN"));
            Assert.AreEqual(636L, Base36.Decode("HO"));
            Assert.AreEqual(637L, Base36.Decode("HP"));
            Assert.AreEqual(638L, Base36.Decode("HQ"));
            Assert.AreEqual(639L, Base36.Decode("HR"));
            Assert.AreEqual(640L, Base36.Decode("HS"));
            Assert.AreEqual(641L, Base36.Decode("HT"));
            Assert.AreEqual(642L, Base36.Decode("HU"));
            Assert.AreEqual(643L, Base36.Decode("HV"));
            Assert.AreEqual(644L, Base36.Decode("HW"));
            Assert.AreEqual(645L, Base36.Decode("HX"));
            Assert.AreEqual(646L, Base36.Decode("HY"));
            Assert.AreEqual(647L, Base36.Decode("HZ"));

            #endregion

            #region I0 to IZ

            Assert.AreEqual(648L, Base36.Decode("I0"));
            Assert.AreEqual(649L, Base36.Decode("I1"));
            Assert.AreEqual(650L, Base36.Decode("I2"));
            Assert.AreEqual(651L, Base36.Decode("I3"));
            Assert.AreEqual(652L, Base36.Decode("I4"));
            Assert.AreEqual(653L, Base36.Decode("I5"));
            Assert.AreEqual(654L, Base36.Decode("I6"));
            Assert.AreEqual(655L, Base36.Decode("I7"));
            Assert.AreEqual(656L, Base36.Decode("I8"));
            Assert.AreEqual(657L, Base36.Decode("I9"));
            Assert.AreEqual(658L, Base36.Decode("IA"));
            Assert.AreEqual(659L, Base36.Decode("IB"));
            Assert.AreEqual(660L, Base36.Decode("IC"));
            Assert.AreEqual(661L, Base36.Decode("ID"));
            Assert.AreEqual(662L, Base36.Decode("IE"));
            Assert.AreEqual(663L, Base36.Decode("IF"));
            Assert.AreEqual(664L, Base36.Decode("IG"));
            Assert.AreEqual(665L, Base36.Decode("IH"));
            Assert.AreEqual(666L, Base36.Decode("II"));
            Assert.AreEqual(667L, Base36.Decode("IJ"));
            Assert.AreEqual(668L, Base36.Decode("IK"));
            Assert.AreEqual(669L, Base36.Decode("IL"));
            Assert.AreEqual(670L, Base36.Decode("IM"));
            Assert.AreEqual(671L, Base36.Decode("IN"));
            Assert.AreEqual(672L, Base36.Decode("IO"));
            Assert.AreEqual(673L, Base36.Decode("IP"));
            Assert.AreEqual(674L, Base36.Decode("IQ"));
            Assert.AreEqual(675L, Base36.Decode("IR"));
            Assert.AreEqual(676L, Base36.Decode("IS"));
            Assert.AreEqual(677L, Base36.Decode("IT"));
            Assert.AreEqual(678L, Base36.Decode("IU"));
            Assert.AreEqual(679L, Base36.Decode("IV"));
            Assert.AreEqual(680L, Base36.Decode("IW"));
            Assert.AreEqual(681L, Base36.Decode("IX"));
            Assert.AreEqual(682L, Base36.Decode("IY"));
            Assert.AreEqual(683L, Base36.Decode("IZ"));

            #endregion

            #region J0 to JZ

            Assert.AreEqual(684L, Base36.Decode("J0"));
            Assert.AreEqual(685L, Base36.Decode("J1"));
            Assert.AreEqual(686L, Base36.Decode("J2"));
            Assert.AreEqual(687L, Base36.Decode("J3"));
            Assert.AreEqual(688L, Base36.Decode("J4"));
            Assert.AreEqual(689L, Base36.Decode("J5"));
            Assert.AreEqual(690L, Base36.Decode("J6"));
            Assert.AreEqual(691L, Base36.Decode("J7"));
            Assert.AreEqual(692L, Base36.Decode("J8"));
            Assert.AreEqual(693L, Base36.Decode("J9"));
            Assert.AreEqual(694L, Base36.Decode("JA"));
            Assert.AreEqual(695L, Base36.Decode("JB"));
            Assert.AreEqual(696L, Base36.Decode("JC"));
            Assert.AreEqual(697L, Base36.Decode("JD"));
            Assert.AreEqual(698L, Base36.Decode("JE"));
            Assert.AreEqual(699L, Base36.Decode("JF"));
            Assert.AreEqual(700L, Base36.Decode("JG"));
            Assert.AreEqual(701L, Base36.Decode("JH"));
            Assert.AreEqual(702L, Base36.Decode("JI"));
            Assert.AreEqual(703L, Base36.Decode("JJ"));
            Assert.AreEqual(704L, Base36.Decode("JK"));
            Assert.AreEqual(705L, Base36.Decode("JL"));
            Assert.AreEqual(706L, Base36.Decode("JM"));
            Assert.AreEqual(707L, Base36.Decode("JN"));
            Assert.AreEqual(708L, Base36.Decode("JO"));
            Assert.AreEqual(709L, Base36.Decode("JP"));
            Assert.AreEqual(710L, Base36.Decode("JQ"));
            Assert.AreEqual(711L, Base36.Decode("JR"));
            Assert.AreEqual(712L, Base36.Decode("JS"));
            Assert.AreEqual(713L, Base36.Decode("JT"));
            Assert.AreEqual(714L, Base36.Decode("JU"));
            Assert.AreEqual(715L, Base36.Decode("JV"));
            Assert.AreEqual(716L, Base36.Decode("JW"));
            Assert.AreEqual(717L, Base36.Decode("JX"));
            Assert.AreEqual(718L, Base36.Decode("JY"));
            Assert.AreEqual(719L, Base36.Decode("JZ"));

            #endregion

            #region K0 to KZ

            Assert.AreEqual(720L, Base36.Decode("K0"));
            Assert.AreEqual(721L, Base36.Decode("K1"));
            Assert.AreEqual(722L, Base36.Decode("K2"));
            Assert.AreEqual(723L, Base36.Decode("K3"));
            Assert.AreEqual(724L, Base36.Decode("K4"));
            Assert.AreEqual(725L, Base36.Decode("K5"));
            Assert.AreEqual(726L, Base36.Decode("K6"));
            Assert.AreEqual(727L, Base36.Decode("K7"));
            Assert.AreEqual(728L, Base36.Decode("K8"));
            Assert.AreEqual(729L, Base36.Decode("K9"));
            Assert.AreEqual(730L, Base36.Decode("KA"));
            Assert.AreEqual(731L, Base36.Decode("KB"));
            Assert.AreEqual(732L, Base36.Decode("KC"));
            Assert.AreEqual(733L, Base36.Decode("KD"));
            Assert.AreEqual(734L, Base36.Decode("KE"));
            Assert.AreEqual(735L, Base36.Decode("KF"));
            Assert.AreEqual(736L, Base36.Decode("KG"));
            Assert.AreEqual(737L, Base36.Decode("KH"));
            Assert.AreEqual(738L, Base36.Decode("KI"));
            Assert.AreEqual(739L, Base36.Decode("KJ"));
            Assert.AreEqual(740L, Base36.Decode("KK"));
            Assert.AreEqual(741L, Base36.Decode("KL"));
            Assert.AreEqual(742L, Base36.Decode("KM"));
            Assert.AreEqual(743L, Base36.Decode("KN"));
            Assert.AreEqual(744L, Base36.Decode("KO"));
            Assert.AreEqual(745L, Base36.Decode("KP"));
            Assert.AreEqual(746L, Base36.Decode("KQ"));
            Assert.AreEqual(747L, Base36.Decode("KR"));
            Assert.AreEqual(748L, Base36.Decode("KS"));
            Assert.AreEqual(749L, Base36.Decode("KT"));
            Assert.AreEqual(750L, Base36.Decode("KU"));
            Assert.AreEqual(751L, Base36.Decode("KV"));
            Assert.AreEqual(752L, Base36.Decode("KW"));
            Assert.AreEqual(753L, Base36.Decode("KX"));
            Assert.AreEqual(754L, Base36.Decode("KY"));
            Assert.AreEqual(755L, Base36.Decode("KZ"));

            #endregion

            #region L0 to LZ

            Assert.AreEqual(756L, Base36.Decode("L0"));
            Assert.AreEqual(757L, Base36.Decode("L1"));
            Assert.AreEqual(758L, Base36.Decode("L2"));
            Assert.AreEqual(759L, Base36.Decode("L3"));
            Assert.AreEqual(760L, Base36.Decode("L4"));
            Assert.AreEqual(761L, Base36.Decode("L5"));
            Assert.AreEqual(762L, Base36.Decode("L6"));
            Assert.AreEqual(763L, Base36.Decode("L7"));
            Assert.AreEqual(764L, Base36.Decode("L8"));
            Assert.AreEqual(765L, Base36.Decode("L9"));
            Assert.AreEqual(766L, Base36.Decode("LA"));
            Assert.AreEqual(767L, Base36.Decode("LB"));
            Assert.AreEqual(768L, Base36.Decode("LC"));
            Assert.AreEqual(769L, Base36.Decode("LD"));
            Assert.AreEqual(770L, Base36.Decode("LE"));
            Assert.AreEqual(771L, Base36.Decode("LF"));
            Assert.AreEqual(772L, Base36.Decode("LG"));
            Assert.AreEqual(773L, Base36.Decode("LH"));
            Assert.AreEqual(774L, Base36.Decode("LI"));
            Assert.AreEqual(775L, Base36.Decode("LJ"));
            Assert.AreEqual(776L, Base36.Decode("LK"));
            Assert.AreEqual(777L, Base36.Decode("LL"));
            Assert.AreEqual(778L, Base36.Decode("LM"));
            Assert.AreEqual(779L, Base36.Decode("LN"));
            Assert.AreEqual(780L, Base36.Decode("LO"));
            Assert.AreEqual(781L, Base36.Decode("LP"));
            Assert.AreEqual(782L, Base36.Decode("LQ"));
            Assert.AreEqual(783L, Base36.Decode("LR"));
            Assert.AreEqual(784L, Base36.Decode("LS"));
            Assert.AreEqual(785L, Base36.Decode("LT"));
            Assert.AreEqual(786L, Base36.Decode("LU"));
            Assert.AreEqual(787L, Base36.Decode("LV"));
            Assert.AreEqual(788L, Base36.Decode("LW"));
            Assert.AreEqual(789L, Base36.Decode("LX"));
            Assert.AreEqual(790L, Base36.Decode("LY"));
            Assert.AreEqual(791L, Base36.Decode("LZ"));

            #endregion

            #region M0 to MZ

            Assert.AreEqual(792L, Base36.Decode("M0"));
            Assert.AreEqual(793L, Base36.Decode("M1"));
            Assert.AreEqual(794L, Base36.Decode("M2"));
            Assert.AreEqual(795L, Base36.Decode("M3"));
            Assert.AreEqual(796L, Base36.Decode("M4"));
            Assert.AreEqual(797L, Base36.Decode("M5"));
            Assert.AreEqual(798L, Base36.Decode("M6"));
            Assert.AreEqual(799L, Base36.Decode("M7"));
            Assert.AreEqual(800L, Base36.Decode("M8"));
            Assert.AreEqual(801L, Base36.Decode("M9"));
            Assert.AreEqual(802L, Base36.Decode("MA"));
            Assert.AreEqual(803L, Base36.Decode("MB"));
            Assert.AreEqual(804L, Base36.Decode("MC"));
            Assert.AreEqual(805L, Base36.Decode("MD"));
            Assert.AreEqual(806L, Base36.Decode("ME"));
            Assert.AreEqual(807L, Base36.Decode("MF"));
            Assert.AreEqual(808L, Base36.Decode("MG"));
            Assert.AreEqual(809L, Base36.Decode("MH"));
            Assert.AreEqual(810L, Base36.Decode("MI"));
            Assert.AreEqual(811L, Base36.Decode("MJ"));
            Assert.AreEqual(812L, Base36.Decode("MK"));
            Assert.AreEqual(813L, Base36.Decode("ML"));
            Assert.AreEqual(814L, Base36.Decode("MM"));
            Assert.AreEqual(815L, Base36.Decode("MN"));
            Assert.AreEqual(816L, Base36.Decode("MO"));
            Assert.AreEqual(817L, Base36.Decode("MP"));
            Assert.AreEqual(818L, Base36.Decode("MQ"));
            Assert.AreEqual(819L, Base36.Decode("MR"));
            Assert.AreEqual(820L, Base36.Decode("MS"));
            Assert.AreEqual(821L, Base36.Decode("MT"));
            Assert.AreEqual(822L, Base36.Decode("MU"));
            Assert.AreEqual(823L, Base36.Decode("MV"));
            Assert.AreEqual(824L, Base36.Decode("MW"));
            Assert.AreEqual(825L, Base36.Decode("MX"));
            Assert.AreEqual(826L, Base36.Decode("MY"));
            Assert.AreEqual(827L, Base36.Decode("MZ"));

            #endregion

            #region N0 to NZ

            Assert.AreEqual(828L, Base36.Decode("N0"));
            Assert.AreEqual(829L, Base36.Decode("N1"));
            Assert.AreEqual(830L, Base36.Decode("N2"));
            Assert.AreEqual(831L, Base36.Decode("N3"));
            Assert.AreEqual(832L, Base36.Decode("N4"));
            Assert.AreEqual(833L, Base36.Decode("N5"));
            Assert.AreEqual(834L, Base36.Decode("N6"));
            Assert.AreEqual(835L, Base36.Decode("N7"));
            Assert.AreEqual(836L, Base36.Decode("N8"));
            Assert.AreEqual(837L, Base36.Decode("N9"));
            Assert.AreEqual(838L, Base36.Decode("NA"));
            Assert.AreEqual(839L, Base36.Decode("NB"));
            Assert.AreEqual(840L, Base36.Decode("NC"));
            Assert.AreEqual(841L, Base36.Decode("ND"));
            Assert.AreEqual(842L, Base36.Decode("NE"));
            Assert.AreEqual(843L, Base36.Decode("NF"));
            Assert.AreEqual(844L, Base36.Decode("NG"));
            Assert.AreEqual(845L, Base36.Decode("NH"));
            Assert.AreEqual(846L, Base36.Decode("NI"));
            Assert.AreEqual(847L, Base36.Decode("NJ"));
            Assert.AreEqual(848L, Base36.Decode("NK"));
            Assert.AreEqual(849L, Base36.Decode("NL"));
            Assert.AreEqual(850L, Base36.Decode("NM"));
            Assert.AreEqual(851L, Base36.Decode("NN"));
            Assert.AreEqual(852L, Base36.Decode("NO"));
            Assert.AreEqual(853L, Base36.Decode("NP"));
            Assert.AreEqual(854L, Base36.Decode("NQ"));
            Assert.AreEqual(855L, Base36.Decode("NR"));
            Assert.AreEqual(856L, Base36.Decode("NS"));
            Assert.AreEqual(857L, Base36.Decode("NT"));
            Assert.AreEqual(858L, Base36.Decode("NU"));
            Assert.AreEqual(859L, Base36.Decode("NV"));
            Assert.AreEqual(860L, Base36.Decode("NW"));
            Assert.AreEqual(861L, Base36.Decode("NX"));
            Assert.AreEqual(862L, Base36.Decode("NY"));
            Assert.AreEqual(863L, Base36.Decode("NZ"));

            #endregion

            #region O0 to OZ

            Assert.AreEqual(864L, Base36.Decode("O0"));
            Assert.AreEqual(865L, Base36.Decode("O1"));
            Assert.AreEqual(866L, Base36.Decode("O2"));
            Assert.AreEqual(867L, Base36.Decode("O3"));
            Assert.AreEqual(868L, Base36.Decode("O4"));
            Assert.AreEqual(869L, Base36.Decode("O5"));
            Assert.AreEqual(870L, Base36.Decode("O6"));
            Assert.AreEqual(871L, Base36.Decode("O7"));
            Assert.AreEqual(872L, Base36.Decode("O8"));
            Assert.AreEqual(873L, Base36.Decode("O9"));
            Assert.AreEqual(874L, Base36.Decode("OA"));
            Assert.AreEqual(875L, Base36.Decode("OB"));
            Assert.AreEqual(876L, Base36.Decode("OC"));
            Assert.AreEqual(877L, Base36.Decode("OD"));
            Assert.AreEqual(878L, Base36.Decode("OE"));
            Assert.AreEqual(879L, Base36.Decode("OF"));
            Assert.AreEqual(880L, Base36.Decode("OG"));
            Assert.AreEqual(881L, Base36.Decode("OH"));
            Assert.AreEqual(882L, Base36.Decode("OI"));
            Assert.AreEqual(883L, Base36.Decode("OJ"));
            Assert.AreEqual(884L, Base36.Decode("OK"));
            Assert.AreEqual(885L, Base36.Decode("OL"));
            Assert.AreEqual(886L, Base36.Decode("OM"));
            Assert.AreEqual(887L, Base36.Decode("ON"));
            Assert.AreEqual(888L, Base36.Decode("OO"));
            Assert.AreEqual(889L, Base36.Decode("OP"));
            Assert.AreEqual(890L, Base36.Decode("OQ"));
            Assert.AreEqual(891L, Base36.Decode("OR"));
            Assert.AreEqual(892L, Base36.Decode("OS"));
            Assert.AreEqual(893L, Base36.Decode("OT"));
            Assert.AreEqual(894L, Base36.Decode("OU"));
            Assert.AreEqual(895L, Base36.Decode("OV"));
            Assert.AreEqual(896L, Base36.Decode("OW"));
            Assert.AreEqual(897L, Base36.Decode("OX"));
            Assert.AreEqual(898L, Base36.Decode("OY"));
            Assert.AreEqual(899L, Base36.Decode("OZ"));

            #endregion

            #region P0 to PZ

            Assert.AreEqual(900L, Base36.Decode("P0"));
            Assert.AreEqual(901L, Base36.Decode("P1"));
            Assert.AreEqual(902L, Base36.Decode("P2"));
            Assert.AreEqual(903L, Base36.Decode("P3"));
            Assert.AreEqual(904L, Base36.Decode("P4"));
            Assert.AreEqual(905L, Base36.Decode("P5"));
            Assert.AreEqual(906L, Base36.Decode("P6"));
            Assert.AreEqual(907L, Base36.Decode("P7"));
            Assert.AreEqual(908L, Base36.Decode("P8"));
            Assert.AreEqual(909L, Base36.Decode("P9"));
            Assert.AreEqual(910L, Base36.Decode("PA"));
            Assert.AreEqual(911L, Base36.Decode("PB"));
            Assert.AreEqual(912L, Base36.Decode("PC"));
            Assert.AreEqual(913L, Base36.Decode("PD"));
            Assert.AreEqual(914L, Base36.Decode("PE"));
            Assert.AreEqual(915L, Base36.Decode("PF"));
            Assert.AreEqual(916L, Base36.Decode("PG"));
            Assert.AreEqual(917L, Base36.Decode("PH"));
            Assert.AreEqual(918L, Base36.Decode("PI"));
            Assert.AreEqual(919L, Base36.Decode("PJ"));
            Assert.AreEqual(920L, Base36.Decode("PK"));
            Assert.AreEqual(921L, Base36.Decode("PL"));
            Assert.AreEqual(922L, Base36.Decode("PM"));
            Assert.AreEqual(923L, Base36.Decode("PN"));
            Assert.AreEqual(924L, Base36.Decode("PO"));
            Assert.AreEqual(925L, Base36.Decode("PP"));
            Assert.AreEqual(926L, Base36.Decode("PQ"));
            Assert.AreEqual(927L, Base36.Decode("PR"));
            Assert.AreEqual(928L, Base36.Decode("PS"));
            Assert.AreEqual(929L, Base36.Decode("PT"));
            Assert.AreEqual(930L, Base36.Decode("PU"));
            Assert.AreEqual(931L, Base36.Decode("PV"));
            Assert.AreEqual(932L, Base36.Decode("PW"));
            Assert.AreEqual(933L, Base36.Decode("PX"));
            Assert.AreEqual(934L, Base36.Decode("PY"));
            Assert.AreEqual(935L, Base36.Decode("PZ"));

            #endregion

            #region Q0 to QZ

            Assert.AreEqual(936L, Base36.Decode("Q0"));
            Assert.AreEqual(937L, Base36.Decode("Q1"));
            Assert.AreEqual(938L, Base36.Decode("Q2"));
            Assert.AreEqual(939L, Base36.Decode("Q3"));
            Assert.AreEqual(940L, Base36.Decode("Q4"));
            Assert.AreEqual(941L, Base36.Decode("Q5"));
            Assert.AreEqual(942L, Base36.Decode("Q6"));
            Assert.AreEqual(943L, Base36.Decode("Q7"));
            Assert.AreEqual(944L, Base36.Decode("Q8"));
            Assert.AreEqual(945L, Base36.Decode("Q9"));
            Assert.AreEqual(946L, Base36.Decode("QA"));
            Assert.AreEqual(947L, Base36.Decode("QB"));
            Assert.AreEqual(948L, Base36.Decode("QC"));
            Assert.AreEqual(949L, Base36.Decode("QD"));
            Assert.AreEqual(950L, Base36.Decode("QE"));
            Assert.AreEqual(951L, Base36.Decode("QF"));
            Assert.AreEqual(952L, Base36.Decode("QG"));
            Assert.AreEqual(953L, Base36.Decode("QH"));
            Assert.AreEqual(954L, Base36.Decode("QI"));
            Assert.AreEqual(955L, Base36.Decode("QJ"));
            Assert.AreEqual(956L, Base36.Decode("QK"));
            Assert.AreEqual(957L, Base36.Decode("QL"));
            Assert.AreEqual(958L, Base36.Decode("QM"));
            Assert.AreEqual(959L, Base36.Decode("QN"));
            Assert.AreEqual(960L, Base36.Decode("QO"));
            Assert.AreEqual(961L, Base36.Decode("QP"));
            Assert.AreEqual(962L, Base36.Decode("QQ"));
            Assert.AreEqual(963L, Base36.Decode("QR"));
            Assert.AreEqual(964L, Base36.Decode("QS"));
            Assert.AreEqual(965L, Base36.Decode("QT"));
            Assert.AreEqual(966L, Base36.Decode("QU"));
            Assert.AreEqual(967L, Base36.Decode("QV"));
            Assert.AreEqual(968L, Base36.Decode("QW"));
            Assert.AreEqual(969L, Base36.Decode("QX"));
            Assert.AreEqual(970L, Base36.Decode("QY"));
            Assert.AreEqual(971L, Base36.Decode("QZ"));

            #endregion

            #region R0 to RZ

            Assert.AreEqual(972L, Base36.Decode("R0"));
            Assert.AreEqual(973L, Base36.Decode("R1"));
            Assert.AreEqual(974L, Base36.Decode("R2"));
            Assert.AreEqual(975L, Base36.Decode("R3"));
            Assert.AreEqual(976L, Base36.Decode("R4"));
            Assert.AreEqual(977L, Base36.Decode("R5"));
            Assert.AreEqual(978L, Base36.Decode("R6"));
            Assert.AreEqual(979L, Base36.Decode("R7"));
            Assert.AreEqual(980L, Base36.Decode("R8"));
            Assert.AreEqual(981L, Base36.Decode("R9"));
            Assert.AreEqual(982L, Base36.Decode("RA"));
            Assert.AreEqual(983L, Base36.Decode("RB"));
            Assert.AreEqual(984L, Base36.Decode("RC"));
            Assert.AreEqual(985L, Base36.Decode("RD"));
            Assert.AreEqual(986L, Base36.Decode("RE"));
            Assert.AreEqual(987L, Base36.Decode("RF"));
            Assert.AreEqual(988L, Base36.Decode("RG"));
            Assert.AreEqual(989L, Base36.Decode("RH"));
            Assert.AreEqual(990L, Base36.Decode("RI"));
            Assert.AreEqual(991L, Base36.Decode("RJ"));
            Assert.AreEqual(992L, Base36.Decode("RK"));
            Assert.AreEqual(993L, Base36.Decode("RL"));
            Assert.AreEqual(994L, Base36.Decode("RM"));
            Assert.AreEqual(995L, Base36.Decode("RN"));
            Assert.AreEqual(996L, Base36.Decode("RO"));
            Assert.AreEqual(997L, Base36.Decode("RP"));
            Assert.AreEqual(998L, Base36.Decode("RQ"));
            Assert.AreEqual(999L, Base36.Decode("RR"));
            Assert.AreEqual(1000L, Base36.Decode("RS"));
            Assert.AreEqual(1001L, Base36.Decode("RT"));
            Assert.AreEqual(1002L, Base36.Decode("RU"));
            Assert.AreEqual(1003L, Base36.Decode("RV"));
            Assert.AreEqual(1004L, Base36.Decode("RW"));
            Assert.AreEqual(1005L, Base36.Decode("RX"));
            Assert.AreEqual(1006L, Base36.Decode("RY"));
            Assert.AreEqual(1007L, Base36.Decode("RZ"));

            #endregion

            #region S0 to SZ

            Assert.AreEqual(1008L, Base36.Decode("S0"));
            Assert.AreEqual(1009L, Base36.Decode("S1"));
            Assert.AreEqual(1010L, Base36.Decode("S2"));
            Assert.AreEqual(1011L, Base36.Decode("S3"));
            Assert.AreEqual(1012L, Base36.Decode("S4"));
            Assert.AreEqual(1013L, Base36.Decode("S5"));
            Assert.AreEqual(1014L, Base36.Decode("S6"));
            Assert.AreEqual(1015L, Base36.Decode("S7"));
            Assert.AreEqual(1016L, Base36.Decode("S8"));
            Assert.AreEqual(1017L, Base36.Decode("S9"));
            Assert.AreEqual(1018L, Base36.Decode("SA"));
            Assert.AreEqual(1019L, Base36.Decode("SB"));
            Assert.AreEqual(1020L, Base36.Decode("SC"));
            Assert.AreEqual(1021L, Base36.Decode("SD"));
            Assert.AreEqual(1022L, Base36.Decode("SE"));
            Assert.AreEqual(1023L, Base36.Decode("SF"));
            Assert.AreEqual(1024L, Base36.Decode("SG"));
            Assert.AreEqual(1025L, Base36.Decode("SH"));
            Assert.AreEqual(1026L, Base36.Decode("SI"));
            Assert.AreEqual(1027L, Base36.Decode("SJ"));
            Assert.AreEqual(1028L, Base36.Decode("SK"));
            Assert.AreEqual(1029L, Base36.Decode("SL"));
            Assert.AreEqual(1030L, Base36.Decode("SM"));
            Assert.AreEqual(1031L, Base36.Decode("SN"));
            Assert.AreEqual(1032L, Base36.Decode("SO"));
            Assert.AreEqual(1033L, Base36.Decode("SP"));
            Assert.AreEqual(1034L, Base36.Decode("SQ"));
            Assert.AreEqual(1035L, Base36.Decode("SR"));
            Assert.AreEqual(1036L, Base36.Decode("SS"));
            Assert.AreEqual(1037L, Base36.Decode("ST"));
            Assert.AreEqual(1038L, Base36.Decode("SU"));
            Assert.AreEqual(1039L, Base36.Decode("SV"));
            Assert.AreEqual(1040L, Base36.Decode("SW"));
            Assert.AreEqual(1041L, Base36.Decode("SX"));
            Assert.AreEqual(1042L, Base36.Decode("SY"));
            Assert.AreEqual(1043L, Base36.Decode("SZ"));

            #endregion

            #region T0 to TZ

            Assert.AreEqual(1044L, Base36.Decode("T0"));
            Assert.AreEqual(1045L, Base36.Decode("T1"));
            Assert.AreEqual(1046L, Base36.Decode("T2"));
            Assert.AreEqual(1047L, Base36.Decode("T3"));
            Assert.AreEqual(1048L, Base36.Decode("T4"));
            Assert.AreEqual(1049L, Base36.Decode("T5"));
            Assert.AreEqual(1050L, Base36.Decode("T6"));
            Assert.AreEqual(1051L, Base36.Decode("T7"));
            Assert.AreEqual(1052L, Base36.Decode("T8"));
            Assert.AreEqual(1053L, Base36.Decode("T9"));
            Assert.AreEqual(1054L, Base36.Decode("TA"));
            Assert.AreEqual(1055L, Base36.Decode("TB"));
            Assert.AreEqual(1056L, Base36.Decode("TC"));
            Assert.AreEqual(1057L, Base36.Decode("TD"));
            Assert.AreEqual(1058L, Base36.Decode("TE"));
            Assert.AreEqual(1059L, Base36.Decode("TF"));
            Assert.AreEqual(1060L, Base36.Decode("TG"));
            Assert.AreEqual(1061L, Base36.Decode("TH"));
            Assert.AreEqual(1062L, Base36.Decode("TI"));
            Assert.AreEqual(1063L, Base36.Decode("TJ"));
            Assert.AreEqual(1064L, Base36.Decode("TK"));
            Assert.AreEqual(1065L, Base36.Decode("TL"));
            Assert.AreEqual(1066L, Base36.Decode("TM"));
            Assert.AreEqual(1067L, Base36.Decode("TN"));
            Assert.AreEqual(1068L, Base36.Decode("TO"));
            Assert.AreEqual(1069L, Base36.Decode("TP"));
            Assert.AreEqual(1070L, Base36.Decode("TQ"));
            Assert.AreEqual(1071L, Base36.Decode("TR"));
            Assert.AreEqual(1072L, Base36.Decode("TS"));
            Assert.AreEqual(1073L, Base36.Decode("TT"));
            Assert.AreEqual(1074L, Base36.Decode("TU"));
            Assert.AreEqual(1075L, Base36.Decode("TV"));
            Assert.AreEqual(1076L, Base36.Decode("TW"));
            Assert.AreEqual(1077L, Base36.Decode("TX"));
            Assert.AreEqual(1078L, Base36.Decode("TY"));
            Assert.AreEqual(1079L, Base36.Decode("TZ"));

            #endregion

            #region U0 to UZ

            Assert.AreEqual(1080L, Base36.Decode("U0"));
            Assert.AreEqual(1081L, Base36.Decode("U1"));
            Assert.AreEqual(1082L, Base36.Decode("U2"));
            Assert.AreEqual(1083L, Base36.Decode("U3"));
            Assert.AreEqual(1084L, Base36.Decode("U4"));
            Assert.AreEqual(1085L, Base36.Decode("U5"));
            Assert.AreEqual(1086L, Base36.Decode("U6"));
            Assert.AreEqual(1087L, Base36.Decode("U7"));
            Assert.AreEqual(1088L, Base36.Decode("U8"));
            Assert.AreEqual(1089L, Base36.Decode("U9"));
            Assert.AreEqual(1090L, Base36.Decode("UA"));
            Assert.AreEqual(1091L, Base36.Decode("UB"));
            Assert.AreEqual(1092L, Base36.Decode("UC"));
            Assert.AreEqual(1093L, Base36.Decode("UD"));
            Assert.AreEqual(1094L, Base36.Decode("UE"));
            Assert.AreEqual(1095L, Base36.Decode("UF"));
            Assert.AreEqual(1096L, Base36.Decode("UG"));
            Assert.AreEqual(1097L, Base36.Decode("UH"));
            Assert.AreEqual(1098L, Base36.Decode("UI"));
            Assert.AreEqual(1099L, Base36.Decode("UJ"));
            Assert.AreEqual(1100L, Base36.Decode("UK"));
            Assert.AreEqual(1101L, Base36.Decode("UL"));
            Assert.AreEqual(1102L, Base36.Decode("UM"));
            Assert.AreEqual(1103L, Base36.Decode("UN"));
            Assert.AreEqual(1104L, Base36.Decode("UO"));
            Assert.AreEqual(1105L, Base36.Decode("UP"));
            Assert.AreEqual(1106L, Base36.Decode("UQ"));
            Assert.AreEqual(1107L, Base36.Decode("UR"));
            Assert.AreEqual(1108L, Base36.Decode("US"));
            Assert.AreEqual(1109L, Base36.Decode("UT"));
            Assert.AreEqual(1110L, Base36.Decode("UU"));
            Assert.AreEqual(1111L, Base36.Decode("UV"));
            Assert.AreEqual(1112L, Base36.Decode("UW"));
            Assert.AreEqual(1113L, Base36.Decode("UX"));
            Assert.AreEqual(1114L, Base36.Decode("UY"));
            Assert.AreEqual(1115L, Base36.Decode("UZ"));

            #endregion

            #region V0 to VZ

            Assert.AreEqual(1116L, Base36.Decode("V0"));
            Assert.AreEqual(1117L, Base36.Decode("V1"));
            Assert.AreEqual(1118L, Base36.Decode("V2"));
            Assert.AreEqual(1119L, Base36.Decode("V3"));
            Assert.AreEqual(1120L, Base36.Decode("V4"));
            Assert.AreEqual(1121L, Base36.Decode("V5"));
            Assert.AreEqual(1122L, Base36.Decode("V6"));
            Assert.AreEqual(1123L, Base36.Decode("V7"));
            Assert.AreEqual(1124L, Base36.Decode("V8"));
            Assert.AreEqual(1125L, Base36.Decode("V9"));
            Assert.AreEqual(1126L, Base36.Decode("VA"));
            Assert.AreEqual(1127L, Base36.Decode("VB"));
            Assert.AreEqual(1128L, Base36.Decode("VC"));
            Assert.AreEqual(1129L, Base36.Decode("VD"));
            Assert.AreEqual(1130L, Base36.Decode("VE"));
            Assert.AreEqual(1131L, Base36.Decode("VF"));
            Assert.AreEqual(1132L, Base36.Decode("VG"));
            Assert.AreEqual(1133L, Base36.Decode("VH"));
            Assert.AreEqual(1134L, Base36.Decode("VI"));
            Assert.AreEqual(1135L, Base36.Decode("VJ"));
            Assert.AreEqual(1136L, Base36.Decode("VK"));
            Assert.AreEqual(1137L, Base36.Decode("VL"));
            Assert.AreEqual(1138L, Base36.Decode("VM"));
            Assert.AreEqual(1139L, Base36.Decode("VN"));
            Assert.AreEqual(1140L, Base36.Decode("VO"));
            Assert.AreEqual(1141L, Base36.Decode("VP"));
            Assert.AreEqual(1142L, Base36.Decode("VQ"));
            Assert.AreEqual(1143L, Base36.Decode("VR"));
            Assert.AreEqual(1144L, Base36.Decode("VS"));
            Assert.AreEqual(1145L, Base36.Decode("VT"));
            Assert.AreEqual(1146L, Base36.Decode("VU"));
            Assert.AreEqual(1147L, Base36.Decode("VV"));
            Assert.AreEqual(1148L, Base36.Decode("VW"));
            Assert.AreEqual(1149L, Base36.Decode("VX"));
            Assert.AreEqual(1150L, Base36.Decode("VY"));
            Assert.AreEqual(1151L, Base36.Decode("VZ"));

            #endregion

            #region W0 to WZ

            Assert.AreEqual(1152L, Base36.Decode("W0"));
            Assert.AreEqual(1153L, Base36.Decode("W1"));
            Assert.AreEqual(1154L, Base36.Decode("W2"));
            Assert.AreEqual(1155L, Base36.Decode("W3"));
            Assert.AreEqual(1156L, Base36.Decode("W4"));
            Assert.AreEqual(1157L, Base36.Decode("W5"));
            Assert.AreEqual(1158L, Base36.Decode("W6"));
            Assert.AreEqual(1159L, Base36.Decode("W7"));
            Assert.AreEqual(1160L, Base36.Decode("W8"));
            Assert.AreEqual(1161L, Base36.Decode("W9"));
            Assert.AreEqual(1162L, Base36.Decode("WA"));
            Assert.AreEqual(1163L, Base36.Decode("WB"));
            Assert.AreEqual(1164L, Base36.Decode("WC"));
            Assert.AreEqual(1165L, Base36.Decode("WD"));
            Assert.AreEqual(1166L, Base36.Decode("WE"));
            Assert.AreEqual(1167L, Base36.Decode("WF"));
            Assert.AreEqual(1168L, Base36.Decode("WG"));
            Assert.AreEqual(1169L, Base36.Decode("WH"));
            Assert.AreEqual(1170L, Base36.Decode("WI"));
            Assert.AreEqual(1171L, Base36.Decode("WJ"));
            Assert.AreEqual(1172L, Base36.Decode("WK"));
            Assert.AreEqual(1173L, Base36.Decode("WL"));
            Assert.AreEqual(1174L, Base36.Decode("WM"));
            Assert.AreEqual(1175L, Base36.Decode("WN"));
            Assert.AreEqual(1176L, Base36.Decode("WO"));
            Assert.AreEqual(1177L, Base36.Decode("WP"));
            Assert.AreEqual(1178L, Base36.Decode("WQ"));
            Assert.AreEqual(1179L, Base36.Decode("WR"));
            Assert.AreEqual(1180L, Base36.Decode("WS"));
            Assert.AreEqual(1181L, Base36.Decode("WT"));
            Assert.AreEqual(1182L, Base36.Decode("WU"));
            Assert.AreEqual(1183L, Base36.Decode("WV"));
            Assert.AreEqual(1184L, Base36.Decode("WW"));
            Assert.AreEqual(1185L, Base36.Decode("WX"));
            Assert.AreEqual(1186L, Base36.Decode("WY"));
            Assert.AreEqual(1187L, Base36.Decode("WZ"));

            #endregion

            #region X0 to XZ

            Assert.AreEqual(1188L, Base36.Decode("X0"));
            Assert.AreEqual(1189L, Base36.Decode("X1"));
            Assert.AreEqual(1190L, Base36.Decode("X2"));
            Assert.AreEqual(1191L, Base36.Decode("X3"));
            Assert.AreEqual(1192L, Base36.Decode("X4"));
            Assert.AreEqual(1193L, Base36.Decode("X5"));
            Assert.AreEqual(1194L, Base36.Decode("X6"));
            Assert.AreEqual(1195L, Base36.Decode("X7"));
            Assert.AreEqual(1196L, Base36.Decode("X8"));
            Assert.AreEqual(1197L, Base36.Decode("X9"));
            Assert.AreEqual(1198L, Base36.Decode("XA"));
            Assert.AreEqual(1199L, Base36.Decode("XB"));
            Assert.AreEqual(1200L, Base36.Decode("XC"));
            Assert.AreEqual(1201L, Base36.Decode("XD"));
            Assert.AreEqual(1202L, Base36.Decode("XE"));
            Assert.AreEqual(1203L, Base36.Decode("XF"));
            Assert.AreEqual(1204L, Base36.Decode("XG"));
            Assert.AreEqual(1205L, Base36.Decode("XH"));
            Assert.AreEqual(1206L, Base36.Decode("XI"));
            Assert.AreEqual(1207L, Base36.Decode("XJ"));
            Assert.AreEqual(1208L, Base36.Decode("XK"));
            Assert.AreEqual(1209L, Base36.Decode("XL"));
            Assert.AreEqual(1210L, Base36.Decode("XM"));
            Assert.AreEqual(1211L, Base36.Decode("XN"));
            Assert.AreEqual(1212L, Base36.Decode("XO"));
            Assert.AreEqual(1213L, Base36.Decode("XP"));
            Assert.AreEqual(1214L, Base36.Decode("XQ"));
            Assert.AreEqual(1215L, Base36.Decode("XR"));
            Assert.AreEqual(1216L, Base36.Decode("XS"));
            Assert.AreEqual(1217L, Base36.Decode("XT"));
            Assert.AreEqual(1218L, Base36.Decode("XU"));
            Assert.AreEqual(1219L, Base36.Decode("XV"));
            Assert.AreEqual(1220L, Base36.Decode("XW"));
            Assert.AreEqual(1221L, Base36.Decode("XX"));
            Assert.AreEqual(1222L, Base36.Decode("XY"));
            Assert.AreEqual(1223L, Base36.Decode("XZ"));

            #endregion

            #region Y0 to YZ

            Assert.AreEqual(1224L, Base36.Decode("Y0"));
            Assert.AreEqual(1225L, Base36.Decode("Y1"));
            Assert.AreEqual(1226L, Base36.Decode("Y2"));
            Assert.AreEqual(1227L, Base36.Decode("Y3"));
            Assert.AreEqual(1228L, Base36.Decode("Y4"));
            Assert.AreEqual(1229L, Base36.Decode("Y5"));
            Assert.AreEqual(1230L, Base36.Decode("Y6"));
            Assert.AreEqual(1231L, Base36.Decode("Y7"));
            Assert.AreEqual(1232L, Base36.Decode("Y8"));
            Assert.AreEqual(1233L, Base36.Decode("Y9"));
            Assert.AreEqual(1234L, Base36.Decode("YA"));
            Assert.AreEqual(1235L, Base36.Decode("YB"));
            Assert.AreEqual(1236L, Base36.Decode("YC"));
            Assert.AreEqual(1237L, Base36.Decode("YD"));
            Assert.AreEqual(1238L, Base36.Decode("YE"));
            Assert.AreEqual(1239L, Base36.Decode("YF"));
            Assert.AreEqual(1240L, Base36.Decode("YG"));
            Assert.AreEqual(1241L, Base36.Decode("YH"));
            Assert.AreEqual(1242L, Base36.Decode("YI"));
            Assert.AreEqual(1243L, Base36.Decode("YJ"));
            Assert.AreEqual(1244L, Base36.Decode("YK"));
            Assert.AreEqual(1245L, Base36.Decode("YL"));
            Assert.AreEqual(1246L, Base36.Decode("YM"));
            Assert.AreEqual(1247L, Base36.Decode("YN"));
            Assert.AreEqual(1248L, Base36.Decode("YO"));
            Assert.AreEqual(1249L, Base36.Decode("YP"));
            Assert.AreEqual(1250L, Base36.Decode("YQ"));
            Assert.AreEqual(1251L, Base36.Decode("YR"));
            Assert.AreEqual(1252L, Base36.Decode("YS"));
            Assert.AreEqual(1253L, Base36.Decode("YT"));
            Assert.AreEqual(1254L, Base36.Decode("YU"));
            Assert.AreEqual(1255L, Base36.Decode("YV"));
            Assert.AreEqual(1256L, Base36.Decode("YW"));
            Assert.AreEqual(1257L, Base36.Decode("YX"));
            Assert.AreEqual(1258L, Base36.Decode("YY"));
            Assert.AreEqual(1259L, Base36.Decode("YZ"));

            #endregion

            #region Z0 to ZZ

            Assert.AreEqual(1260L, Base36.Decode("Z0"));
            Assert.AreEqual(1261L, Base36.Decode("Z1"));
            Assert.AreEqual(1262L, Base36.Decode("Z2"));
            Assert.AreEqual(1263L, Base36.Decode("Z3"));
            Assert.AreEqual(1264L, Base36.Decode("Z4"));
            Assert.AreEqual(1265L, Base36.Decode("Z5"));
            Assert.AreEqual(1266L, Base36.Decode("Z6"));
            Assert.AreEqual(1267L, Base36.Decode("Z7"));
            Assert.AreEqual(1268L, Base36.Decode("Z8"));
            Assert.AreEqual(1269L, Base36.Decode("Z9"));
            Assert.AreEqual(1270L, Base36.Decode("ZA"));
            Assert.AreEqual(1271L, Base36.Decode("ZB"));
            Assert.AreEqual(1272L, Base36.Decode("ZC"));
            Assert.AreEqual(1273L, Base36.Decode("ZD"));
            Assert.AreEqual(1274L, Base36.Decode("ZE"));
            Assert.AreEqual(1275L, Base36.Decode("ZF"));
            Assert.AreEqual(1276L, Base36.Decode("ZG"));
            Assert.AreEqual(1277L, Base36.Decode("ZH"));
            Assert.AreEqual(1278L, Base36.Decode("ZI"));
            Assert.AreEqual(1279L, Base36.Decode("ZJ"));
            Assert.AreEqual(1280L, Base36.Decode("ZK"));
            Assert.AreEqual(1281L, Base36.Decode("ZL"));
            Assert.AreEqual(1282L, Base36.Decode("ZM"));
            Assert.AreEqual(1283L, Base36.Decode("ZN"));
            Assert.AreEqual(1284L, Base36.Decode("ZO"));
            Assert.AreEqual(1285L, Base36.Decode("ZP"));
            Assert.AreEqual(1286L, Base36.Decode("ZQ"));
            Assert.AreEqual(1287L, Base36.Decode("ZR"));
            Assert.AreEqual(1288L, Base36.Decode("ZS"));
            Assert.AreEqual(1289L, Base36.Decode("ZT"));
            Assert.AreEqual(1290L, Base36.Decode("ZU"));
            Assert.AreEqual(1291L, Base36.Decode("ZV"));
            Assert.AreEqual(1292L, Base36.Decode("ZW"));
            Assert.AreEqual(1293L, Base36.Decode("ZX"));
            Assert.AreEqual(1294L, Base36.Decode("ZY"));
            Assert.AreEqual(1295L, Base36.Decode("ZZ"));

            #endregion
        }
    }
}
