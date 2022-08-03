using System;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Versioning;

/// <summary>
///  Task3 - Implement an image cache using WeakReference; files should be loaded from the disk
/// </summary>
///WeakReference - Ha a hívott oldalon megszűnik a referencea (ahonnan az Add-ot hívtuk), a GC-nek engedi a memóriából felszabadítani az adatot. 

namespace ASMT_prep
{
    [SupportedOSPlatform("windows")]
    public class PictureManager
    {
        List<WeakReference<Image>> pictures;

        public void Add(Image image)
        {
            if (image == null)
                return;

            pictures.Add(new WeakReference<Image>(image));
        }

        public IEnumerable<Image> GetAll()
        {
            var deletedItems = new List<WeakReference<Image>>();
            foreach (var weakImage in pictures)
            {
                if (weakImage.TryGetTarget(out Image image))
                    yield return image;
                //Időközben megszűnhetett a strong reference -> GC felszabadította -> nincs adat a hivatkozott memória terület.
                else
                    deletedItems.Add(weakImage);
            }

            foreach (var deletedImage in deletedItems)
                pictures.Remove(deletedImage);
        }
    }
}