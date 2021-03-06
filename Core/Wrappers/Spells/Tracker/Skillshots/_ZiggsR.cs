﻿namespace LeagueSharp.SDK.Core.Wrappers.Spells.Tracker.Skillshots
{
    public class _ZiggsR : Skillshot
    {
        private CirclePoly Circle;

        #region Constructors and Destructors

        public _ZiggsR()
            : base("ZiggsR")
        {
        }

        #endregion

        #region Public Properties

        public new int Delay => (int)(1500 + 1500 * this.EndPosition.Distance(this.StartPosition) / this.SData.Range);

        #endregion

        #region Public Methods and Operators

        internal override void UpdatePolygon()
        {
            Circle = new CirclePoly(this.EndPosition, this.SData.Radius);
            this.UpdatePath();
        }

        internal override void UpdatePath()
        {
            this.Path = Circle.ToClipperPath();
        }

        #endregion
    }
}