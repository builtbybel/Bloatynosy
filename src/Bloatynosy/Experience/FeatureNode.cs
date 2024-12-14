using System.Windows.Forms;

namespace BloatynosyNue
{
    internal class FeatureNode : TreeNode
    {
        public FeatureBase Feature { get; private set; }

        public FeatureNode(FeatureBase feature)
        {
            Feature = feature;
            Text = Feature.ID();
        }
    }
}