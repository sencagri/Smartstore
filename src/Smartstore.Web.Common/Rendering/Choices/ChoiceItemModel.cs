﻿using Smartstore.Web.Modelling;

namespace Smartstore.Web.Rendering.Choices
{
    public abstract class ChoiceItemModel : EntityModelBase
    {
        public string Name { get; set; }
        public string SeName { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Color { get; set; }
        public string PriceAdjustment { get; set; }
        public decimal PriceAdjustmentValue { get; set; }
        public decimal QuantityInfo { get; set; }
        public bool IsPreSelected { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsUnavailable { get; set; }
        public string ImageUrl { get; set; }

        public abstract string GetItemLabel();
    }
}
