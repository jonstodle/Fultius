using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Fultius {
    public class Settings {
        public string ApplicationTitle { get { return "Fultius"; } }

        // #3b5998
        public Color FacebookStrongColor { get { return Color.FromArgb(255, 0x3b, 0x59, 0x98); } }

        // #8b9dc3
        public Color FacebookNeutralColor { get { return Color.FromArgb(255, 0x8b, 0x9d, 0xc3); } }

        // #f7f7f7
        public Color FacebookSutbleColor { get { return Color.FromArgb(255, 0xf7, 0xf7, 0xf7); } }

        // #dfe3ee
        public Color FacebookFaintColor { get { return Color.FromArgb(255, 0xdf, 0xe3, 0xee); } }

        public SolidColorBrush FacebookStrongBrush { get { return new SolidColorBrush(FacebookStrongColor); } }

        public SolidColorBrush FacebookNeutralBrush { get { return new SolidColorBrush(FacebookNeutralColor); } }

        public SolidColorBrush FacebookSutbleBrush { get { return new SolidColorBrush(FacebookSutbleColor); } }

        public SolidColorBrush FacebookFaintBrush { get { return new SolidColorBrush(FacebookFaintColor); } }
    }
}
