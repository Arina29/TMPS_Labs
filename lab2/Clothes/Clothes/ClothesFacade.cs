using Clothes.ClothItems;

namespace Clothes
{
    public class BlouseFacade
    {
        private BlouseProxy _blueBlouseProxy;
        private BlouseProxy _blueBlouseWithFlowersProxy;
        private BlouseProxy _redBlouseProxy;

        public BlouseFacade()
        {
            _redBlouseProxy = new BlouseProxy(new RedBlouse());
            _blueBlouseProxy = new BlouseProxy(new BlueBlouse());
            _blueBlouseWithFlowersProxy = new BlouseProxy(new BlueBlouseWithPatterns(new BlueBlouse()));
        }

        public void SewBlouse()
        {
            _redBlouseProxy.Sew(_redBlouseProxy.GetMaterials());
            _blueBlouseProxy.Sew(_blueBlouseProxy.GetMaterials());
            _blueBlouseWithFlowersProxy.Sew(_blueBlouseWithFlowersProxy.GetMaterials());
        }

    }

    public class TrousersFacade
    {
        private TrousersProxy _redTrousers;
        private TrousersProxy _blueTrousers;

        public TrousersFacade()
        {
            _redTrousers = new TrousersProxy(new RedTrousers());
            _blueTrousers = new TrousersProxy(new BlueTrousers());
        }

        public void SewTrousers()
        {
            _redTrousers.Sew(_redTrousers.GetMaterials());
            _blueTrousers.Sew(_blueTrousers.GetMaterials());
        }

    }

    public class JacketFacade
    {
        private LeatherJacketProxy _redJacket;
        private LeatherJacketProxy _blueJacket;

        public JacketFacade()
        {
            _redJacket = new LeatherJacketProxy(new RedLeatherJacket());
            _blueJacket = new LeatherJacketProxy(new BlueLeatherJacket());
        }

        public void SewJackets()
        {
            _redJacket.Sew(_redJacket.GetMaterials());
            _blueJacket.Sew(_blueJacket.GetMaterials());
        }
    }
}
