using System;

using R5T.Guide;


namespace R5T.Sindia
{
    public class AnomalyIdentity : TypedGuid
    {
        #region Static

        public static AnomalyIdentity New()
        {
            var anomalyIdentity = new AnomalyIdentity();
            return anomalyIdentity;
        }

        public static AnomalyIdentity From(Guid guid)
        {
            var anomalyIdentity = new AnomalyIdentity(guid);
            return anomalyIdentity;
        }

        #endregion


        public AnomalyIdentity(Guid value)
            : base(value)
        {
        }

        public AnomalyIdentity()
            : this(Guid.NewGuid())
        {
        }
    }
}
