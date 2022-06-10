namespace OgameAPI.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("serverData")]
    public partial class ServerData
    {

        private string nameField;

        private ushort numberField;

        private string languageField;

        private string timezoneField;

        private string timezoneOffsetField;

        private string domainField;

        private string versionField;

        private byte speedField;

        private byte speedFleetPeacefulField;

        private byte speedFleetWarField;

        private byte speedFleetHoldingField;

        private byte galaxiesField;

        private ushort systemsField;

        private byte acsField;

        private byte rapidFireField;

        private byte defToTFField;

        private decimal debrisFactorField;

        private byte debrisFactorDefField;

        private decimal repairFactorField;

        private uint newbieProtectionLimitField;

        private ushort newbieProtectionHighField;

        private uint topScoreField;

        private byte bonusFieldsField;

        private byte donutGalaxyField;

        private byte donutSystemField;

        private byte wfEnabledField;

        private uint wfMinimumRessLostField;

        private byte wfMinimumLossPercentageField;

        private byte wfBasicPercentageRepairableField;

        private byte globalDeuteriumSaveFactorField;

        private byte bashlimitField;

        private byte probeCargoField;

        private byte researchDurationDivisorField;

        private ushort darkMatterNewAcountField;

        private byte cargoHyperspaceTechMultiplierField;

        private byte marketplaceEnabledField;

        private decimal marketplaceBasicTradeRatioMetalField;

        private decimal marketplaceBasicTradeRatioCrystalField;

        private byte marketplaceBasicTradeRatioDeuteriumField;

        private decimal marketplacePriceRangeLowerField;

        private byte marketplacePriceRangeUpperField;

        private decimal marketplaceTaxNormalUserField;

        private decimal marketplaceTaxAdmiralField;

        private decimal marketplaceTaxCancelOfferField;

        private decimal marketplaceTaxNotSoldField;

        private byte marketplaceOfferTimeoutField;

        private byte characterClassesEnabledField;

        private decimal minerBonusResourceProductionField;

        private decimal minerBonusFasterTradingShipsField;

        private decimal minerBonusIncreasedCargoCapacityForTradingShipsField;

        private byte minerBonusAdditionalFleetSlotsField;

        private byte minerBonusAdditionalMarketSlotsField;

        private decimal minerBonusAdditionalCrawlerField;

        private decimal minerBonusMaxCrawlerField;

        private byte minerBonusEnergyField;

        private byte minerBonusOverloadCrawlerField;

        private decimal resourceBuggyProductionBoostField;

        private decimal resourceBuggyMaxProductionBoostField;

        private byte resourceBuggyEnergyConsumptionPerUnitField;

        private byte warriorBonusFasterCombatShipsField;

        private byte warriorBonusFasterRecyclersField;

        private decimal warriorBonusFuelConsumptionField;

        private decimal warriorBonusRecyclerFuelConsumptionField;

        private decimal warriorBonusRecyclerCargoCapacityField;

        private byte warriorBonusAdditionalFleetSlotsField;

        private byte warriorBonusAdditionalMoonFieldsField;

        private byte warriorBonusFleetHalfSpeedField;

        private byte warriorBonusAttackerWreckfieldField;

        private decimal combatDebrisFieldLimitField;

        private decimal explorerBonusIncreasedResearchSpeedField;

        private decimal explorerBonusIncreasedExpeditionOutcomeField;

        private decimal explorerBonusLargerPlanetsField;

        private byte explorerUnitItemsPerDayField;

        private decimal explorerBonusPhalanxRangeField;

        private byte explorerBonusPlunderInactiveField;

        private decimal explorerBonusExpeditionEnemyReductionField;

        private byte explorerBonusAdditionalExpeditionSlotsField;

        private byte resourceProductionIncreaseCrystalDefaultField;

        private decimal resourceProductionIncreaseCrystalPos1Field;

        private decimal resourceProductionIncreaseCrystalPos2Field;

        private decimal resourceProductionIncreaseCrystalPos3Field;

        private decimal exodusRatioMetalField;

        private decimal exodusRatioCrystalField;

        private byte exodusRatioDeuteriumField;

        private uint timestampField;

        private string serverIdField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ushort number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string timezone
        {
            get
            {
                return this.timezoneField;
            }
            set
            {
                this.timezoneField = value;
            }
        }

        /// <remarks/>
        public string timezoneOffset
        {
            get
            {
                return this.timezoneOffsetField;
            }
            set
            {
                this.timezoneOffsetField = value;
            }
        }

        /// <remarks/>
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public byte speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        public byte speedFleetPeaceful
        {
            get
            {
                return this.speedFleetPeacefulField;
            }
            set
            {
                this.speedFleetPeacefulField = value;
            }
        }

        /// <remarks/>
        public byte speedFleetWar
        {
            get
            {
                return this.speedFleetWarField;
            }
            set
            {
                this.speedFleetWarField = value;
            }
        }

        /// <remarks/>
        public byte speedFleetHolding
        {
            get
            {
                return this.speedFleetHoldingField;
            }
            set
            {
                this.speedFleetHoldingField = value;
            }
        }

        /// <remarks/>
        public byte galaxies
        {
            get
            {
                return this.galaxiesField;
            }
            set
            {
                this.galaxiesField = value;
            }
        }

        /// <remarks/>
        public ushort systems
        {
            get
            {
                return this.systemsField;
            }
            set
            {
                this.systemsField = value;
            }
        }

        /// <remarks/>
        public byte acs
        {
            get
            {
                return this.acsField;
            }
            set
            {
                this.acsField = value;
            }
        }

        /// <remarks/>
        public byte rapidFire
        {
            get
            {
                return this.rapidFireField;
            }
            set
            {
                this.rapidFireField = value;
            }
        }

        /// <remarks/>
        public byte defToTF
        {
            get
            {
                return this.defToTFField;
            }
            set
            {
                this.defToTFField = value;
            }
        }

        /// <remarks/>
        public decimal debrisFactor
        {
            get
            {
                return this.debrisFactorField;
            }
            set
            {
                this.debrisFactorField = value;
            }
        }

        /// <remarks/>
        public byte debrisFactorDef
        {
            get
            {
                return this.debrisFactorDefField;
            }
            set
            {
                this.debrisFactorDefField = value;
            }
        }

        /// <remarks/>
        public decimal repairFactor
        {
            get
            {
                return this.repairFactorField;
            }
            set
            {
                this.repairFactorField = value;
            }
        }

        /// <remarks/>
        public uint newbieProtectionLimit
        {
            get
            {
                return this.newbieProtectionLimitField;
            }
            set
            {
                this.newbieProtectionLimitField = value;
            }
        }

        /// <remarks/>
        public ushort newbieProtectionHigh
        {
            get
            {
                return this.newbieProtectionHighField;
            }
            set
            {
                this.newbieProtectionHighField = value;
            }
        }

        /// <remarks/>
        public uint topScore
        {
            get
            {
                return this.topScoreField;
            }
            set
            {
                this.topScoreField = value;
            }
        }

        /// <remarks/>
        public byte bonusFields
        {
            get
            {
                return this.bonusFieldsField;
            }
            set
            {
                this.bonusFieldsField = value;
            }
        }

        /// <remarks/>
        public byte donutGalaxy
        {
            get
            {
                return this.donutGalaxyField;
            }
            set
            {
                this.donutGalaxyField = value;
            }
        }

        /// <remarks/>
        public byte donutSystem
        {
            get
            {
                return this.donutSystemField;
            }
            set
            {
                this.donutSystemField = value;
            }
        }

        /// <remarks/>
        public byte wfEnabled
        {
            get
            {
                return this.wfEnabledField;
            }
            set
            {
                this.wfEnabledField = value;
            }
        }

        /// <remarks/>
        public uint wfMinimumRessLost
        {
            get
            {
                return this.wfMinimumRessLostField;
            }
            set
            {
                this.wfMinimumRessLostField = value;
            }
        }

        /// <remarks/>
        public byte wfMinimumLossPercentage
        {
            get
            {
                return this.wfMinimumLossPercentageField;
            }
            set
            {
                this.wfMinimumLossPercentageField = value;
            }
        }

        /// <remarks/>
        public byte wfBasicPercentageRepairable
        {
            get
            {
                return this.wfBasicPercentageRepairableField;
            }
            set
            {
                this.wfBasicPercentageRepairableField = value;
            }
        }

        /// <remarks/>
        public byte globalDeuteriumSaveFactor
        {
            get
            {
                return this.globalDeuteriumSaveFactorField;
            }
            set
            {
                this.globalDeuteriumSaveFactorField = value;
            }
        }

        /// <remarks/>
        public byte bashlimit
        {
            get
            {
                return this.bashlimitField;
            }
            set
            {
                this.bashlimitField = value;
            }
        }

        /// <remarks/>
        public byte probeCargo
        {
            get
            {
                return this.probeCargoField;
            }
            set
            {
                this.probeCargoField = value;
            }
        }

        /// <remarks/>
        public byte researchDurationDivisor
        {
            get
            {
                return this.researchDurationDivisorField;
            }
            set
            {
                this.researchDurationDivisorField = value;
            }
        }

        /// <remarks/>
        public ushort darkMatterNewAcount
        {
            get
            {
                return this.darkMatterNewAcountField;
            }
            set
            {
                this.darkMatterNewAcountField = value;
            }
        }

        /// <remarks/>
        public byte cargoHyperspaceTechMultiplier
        {
            get
            {
                return this.cargoHyperspaceTechMultiplierField;
            }
            set
            {
                this.cargoHyperspaceTechMultiplierField = value;
            }
        }

        /// <remarks/>
        public byte marketplaceEnabled
        {
            get
            {
                return this.marketplaceEnabledField;
            }
            set
            {
                this.marketplaceEnabledField = value;
            }
        }

        /// <remarks/>
        public decimal marketplaceBasicTradeRatioMetal
        {
            get
            {
                return this.marketplaceBasicTradeRatioMetalField;
            }
            set
            {
                this.marketplaceBasicTradeRatioMetalField = value;
            }
        }

        /// <remarks/>
        public decimal marketplaceBasicTradeRatioCrystal
        {
            get
            {
                return this.marketplaceBasicTradeRatioCrystalField;
            }
            set
            {
                this.marketplaceBasicTradeRatioCrystalField = value;
            }
        }

        /// <remarks/>
        public byte marketplaceBasicTradeRatioDeuterium
        {
            get
            {
                return this.marketplaceBasicTradeRatioDeuteriumField;
            }
            set
            {
                this.marketplaceBasicTradeRatioDeuteriumField = value;
            }
        }

        /// <remarks/>
        public decimal marketplacePriceRangeLower
        {
            get
            {
                return this.marketplacePriceRangeLowerField;
            }
            set
            {
                this.marketplacePriceRangeLowerField = value;
            }
        }

        /// <remarks/>
        public byte marketplacePriceRangeUpper
        {
            get
            {
                return this.marketplacePriceRangeUpperField;
            }
            set
            {
                this.marketplacePriceRangeUpperField = value;
            }
        }

        /// <remarks/>
        public decimal marketplaceTaxNormalUser
        {
            get
            {
                return this.marketplaceTaxNormalUserField;
            }
            set
            {
                this.marketplaceTaxNormalUserField = value;
            }
        }

        /// <remarks/>
        public decimal marketplaceTaxAdmiral
        {
            get
            {
                return this.marketplaceTaxAdmiralField;
            }
            set
            {
                this.marketplaceTaxAdmiralField = value;
            }
        }

        /// <remarks/>
        public decimal marketplaceTaxCancelOffer
        {
            get
            {
                return this.marketplaceTaxCancelOfferField;
            }
            set
            {
                this.marketplaceTaxCancelOfferField = value;
            }
        }

        /// <remarks/>
        public decimal marketplaceTaxNotSold
        {
            get
            {
                return this.marketplaceTaxNotSoldField;
            }
            set
            {
                this.marketplaceTaxNotSoldField = value;
            }
        }

        /// <remarks/>
        public byte marketplaceOfferTimeout
        {
            get
            {
                return this.marketplaceOfferTimeoutField;
            }
            set
            {
                this.marketplaceOfferTimeoutField = value;
            }
        }

        /// <remarks/>
        public byte characterClassesEnabled
        {
            get
            {
                return this.characterClassesEnabledField;
            }
            set
            {
                this.characterClassesEnabledField = value;
            }
        }

        /// <remarks/>
        public decimal minerBonusResourceProduction
        {
            get
            {
                return this.minerBonusResourceProductionField;
            }
            set
            {
                this.minerBonusResourceProductionField = value;
            }
        }

        /// <remarks/>
        public decimal minerBonusFasterTradingShips
        {
            get
            {
                return this.minerBonusFasterTradingShipsField;
            }
            set
            {
                this.minerBonusFasterTradingShipsField = value;
            }
        }

        /// <remarks/>
        public decimal minerBonusIncreasedCargoCapacityForTradingShips
        {
            get
            {
                return this.minerBonusIncreasedCargoCapacityForTradingShipsField;
            }
            set
            {
                this.minerBonusIncreasedCargoCapacityForTradingShipsField = value;
            }
        }

        /// <remarks/>
        public byte minerBonusAdditionalFleetSlots
        {
            get
            {
                return this.minerBonusAdditionalFleetSlotsField;
            }
            set
            {
                this.minerBonusAdditionalFleetSlotsField = value;
            }
        }

        /// <remarks/>
        public byte minerBonusAdditionalMarketSlots
        {
            get
            {
                return this.minerBonusAdditionalMarketSlotsField;
            }
            set
            {
                this.minerBonusAdditionalMarketSlotsField = value;
            }
        }

        /// <remarks/>
        public decimal minerBonusAdditionalCrawler
        {
            get
            {
                return this.minerBonusAdditionalCrawlerField;
            }
            set
            {
                this.minerBonusAdditionalCrawlerField = value;
            }
        }

        /// <remarks/>
        public decimal minerBonusMaxCrawler
        {
            get
            {
                return this.minerBonusMaxCrawlerField;
            }
            set
            {
                this.minerBonusMaxCrawlerField = value;
            }
        }

        /// <remarks/>
        public byte minerBonusEnergy
        {
            get
            {
                return this.minerBonusEnergyField;
            }
            set
            {
                this.minerBonusEnergyField = value;
            }
        }

        /// <remarks/>
        public byte minerBonusOverloadCrawler
        {
            get
            {
                return this.minerBonusOverloadCrawlerField;
            }
            set
            {
                this.minerBonusOverloadCrawlerField = value;
            }
        }

        /// <remarks/>
        public decimal resourceBuggyProductionBoost
        {
            get
            {
                return this.resourceBuggyProductionBoostField;
            }
            set
            {
                this.resourceBuggyProductionBoostField = value;
            }
        }

        /// <remarks/>
        public decimal resourceBuggyMaxProductionBoost
        {
            get
            {
                return this.resourceBuggyMaxProductionBoostField;
            }
            set
            {
                this.resourceBuggyMaxProductionBoostField = value;
            }
        }

        /// <remarks/>
        public byte resourceBuggyEnergyConsumptionPerUnit
        {
            get
            {
                return this.resourceBuggyEnergyConsumptionPerUnitField;
            }
            set
            {
                this.resourceBuggyEnergyConsumptionPerUnitField = value;
            }
        }

        /// <remarks/>
        public byte warriorBonusFasterCombatShips
        {
            get
            {
                return this.warriorBonusFasterCombatShipsField;
            }
            set
            {
                this.warriorBonusFasterCombatShipsField = value;
            }
        }

        /// <remarks/>
        public byte warriorBonusFasterRecyclers
        {
            get
            {
                return this.warriorBonusFasterRecyclersField;
            }
            set
            {
                this.warriorBonusFasterRecyclersField = value;
            }
        }

        /// <remarks/>
        public decimal warriorBonusFuelConsumption
        {
            get
            {
                return this.warriorBonusFuelConsumptionField;
            }
            set
            {
                this.warriorBonusFuelConsumptionField = value;
            }
        }

        /// <remarks/>
        public decimal warriorBonusRecyclerFuelConsumption
        {
            get
            {
                return this.warriorBonusRecyclerFuelConsumptionField;
            }
            set
            {
                this.warriorBonusRecyclerFuelConsumptionField = value;
            }
        }

        /// <remarks/>
        public decimal warriorBonusRecyclerCargoCapacity
        {
            get
            {
                return this.warriorBonusRecyclerCargoCapacityField;
            }
            set
            {
                this.warriorBonusRecyclerCargoCapacityField = value;
            }
        }

        /// <remarks/>
        public byte warriorBonusAdditionalFleetSlots
        {
            get
            {
                return this.warriorBonusAdditionalFleetSlotsField;
            }
            set
            {
                this.warriorBonusAdditionalFleetSlotsField = value;
            }
        }

        /// <remarks/>
        public byte warriorBonusAdditionalMoonFields
        {
            get
            {
                return this.warriorBonusAdditionalMoonFieldsField;
            }
            set
            {
                this.warriorBonusAdditionalMoonFieldsField = value;
            }
        }

        /// <remarks/>
        public byte warriorBonusFleetHalfSpeed
        {
            get
            {
                return this.warriorBonusFleetHalfSpeedField;
            }
            set
            {
                this.warriorBonusFleetHalfSpeedField = value;
            }
        }

        /// <remarks/>
        public byte warriorBonusAttackerWreckfield
        {
            get
            {
                return this.warriorBonusAttackerWreckfieldField;
            }
            set
            {
                this.warriorBonusAttackerWreckfieldField = value;
            }
        }

        /// <remarks/>
        public decimal combatDebrisFieldLimit
        {
            get
            {
                return this.combatDebrisFieldLimitField;
            }
            set
            {
                this.combatDebrisFieldLimitField = value;
            }
        }

        /// <remarks/>
        public decimal explorerBonusIncreasedResearchSpeed
        {
            get
            {
                return this.explorerBonusIncreasedResearchSpeedField;
            }
            set
            {
                this.explorerBonusIncreasedResearchSpeedField = value;
            }
        }

        /// <remarks/>
        public decimal explorerBonusIncreasedExpeditionOutcome
        {
            get
            {
                return this.explorerBonusIncreasedExpeditionOutcomeField;
            }
            set
            {
                this.explorerBonusIncreasedExpeditionOutcomeField = value;
            }
        }

        /// <remarks/>
        public decimal explorerBonusLargerPlanets
        {
            get
            {
                return this.explorerBonusLargerPlanetsField;
            }
            set
            {
                this.explorerBonusLargerPlanetsField = value;
            }
        }

        /// <remarks/>
        public byte explorerUnitItemsPerDay
        {
            get
            {
                return this.explorerUnitItemsPerDayField;
            }
            set
            {
                this.explorerUnitItemsPerDayField = value;
            }
        }

        /// <remarks/>
        public decimal explorerBonusPhalanxRange
        {
            get
            {
                return this.explorerBonusPhalanxRangeField;
            }
            set
            {
                this.explorerBonusPhalanxRangeField = value;
            }
        }

        /// <remarks/>
        public byte explorerBonusPlunderInactive
        {
            get
            {
                return this.explorerBonusPlunderInactiveField;
            }
            set
            {
                this.explorerBonusPlunderInactiveField = value;
            }
        }

        /// <remarks/>
        public decimal explorerBonusExpeditionEnemyReduction
        {
            get
            {
                return this.explorerBonusExpeditionEnemyReductionField;
            }
            set
            {
                this.explorerBonusExpeditionEnemyReductionField = value;
            }
        }

        /// <remarks/>
        public byte explorerBonusAdditionalExpeditionSlots
        {
            get
            {
                return this.explorerBonusAdditionalExpeditionSlotsField;
            }
            set
            {
                this.explorerBonusAdditionalExpeditionSlotsField = value;
            }
        }

        /// <remarks/>
        public byte resourceProductionIncreaseCrystalDefault
        {
            get
            {
                return this.resourceProductionIncreaseCrystalDefaultField;
            }
            set
            {
                this.resourceProductionIncreaseCrystalDefaultField = value;
            }
        }

        /// <remarks/>
        public decimal resourceProductionIncreaseCrystalPos1
        {
            get
            {
                return this.resourceProductionIncreaseCrystalPos1Field;
            }
            set
            {
                this.resourceProductionIncreaseCrystalPos1Field = value;
            }
        }

        /// <remarks/>
        public decimal resourceProductionIncreaseCrystalPos2
        {
            get
            {
                return this.resourceProductionIncreaseCrystalPos2Field;
            }
            set
            {
                this.resourceProductionIncreaseCrystalPos2Field = value;
            }
        }

        /// <remarks/>
        public decimal resourceProductionIncreaseCrystalPos3
        {
            get
            {
                return this.resourceProductionIncreaseCrystalPos3Field;
            }
            set
            {
                this.resourceProductionIncreaseCrystalPos3Field = value;
            }
        }

        /// <remarks/>
        public decimal exodusRatioMetal
        {
            get
            {
                return this.exodusRatioMetalField;
            }
            set
            {
                this.exodusRatioMetalField = value;
            }
        }

        /// <remarks/>
        public decimal exodusRatioCrystal
        {
            get
            {
                return this.exodusRatioCrystalField;
            }
            set
            {
                this.exodusRatioCrystalField = value;
            }
        }

        /// <remarks/>
        public byte exodusRatioDeuterium
        {
            get
            {
                return this.exodusRatioDeuteriumField;
            }
            set
            {
                this.exodusRatioDeuteriumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serverId
        {
            get
            {
                return this.serverIdField;
            }
            set
            {
                this.serverIdField = value;
            }
        }
    }


}
