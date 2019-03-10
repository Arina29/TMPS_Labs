using Clothes.ClothItems;

namespace Clothes
{
    public class ClothesFacade
    {
        private BlouseProxy _blueBlouseProxy;
        private BlouseProxy _blueBlouseWithFlowersProxy;
        private BlouseProxy _redBlouseProxy;
        private TrousersProxy _redTrousers;
        private TrousersProxy _blueTrousers;
        private LeatherJacketProxy _redJacket;
        private LeatherJacketProxy _blueJacket;

        public ClothesFacade()
        {
            _redBlouseProxy = new BlouseProxy(new RedBlouse());
            _blueBlouseProxy = new BlouseProxy(new BlueBlouse());
            _blueBlouseWithFlowersProxy = new BlouseProxy(new BlueBlouseWithPatterns(new BlueBlouse()));
            _redTrousers = new TrousersProxy(new RedTrousers());
            _blueTrousers = new TrousersProxy(new BlueTrousers());
            _redJacket = new LeatherJacketProxy(new RedLeatherJacket());
            _blueJacket = new LeatherJacketProxy(new BlueLeatherJacket());
        }

        public void SewBlouse()
        {
            _redBlouseProxy.Sew(_redBlouseProxy.GetMaterials());
            _blueBlouseProxy.Sew(_blueBlouseProxy.GetMaterials());
            _blueBlouseWithFlowersProxy.Sew(_blueBlouseWithFlowersProxy.GetMaterials());
        }

        public void SewTrousers()
        {
            _redTrousers.Sew(_redTrousers.GetMaterials());
            _blueTrousers.Sew(_blueTrousers.GetMaterials());
        }

        public void SewJackets()
        {
            _redJacket.Sew(_redJacket.GetMaterials());
            _blueJacket.Sew(_blueJacket.GetMaterials());
        }

    }
}
