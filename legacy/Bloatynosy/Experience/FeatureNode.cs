using System.Windows.Forms;

namespace Bloatynosy
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