﻿using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Warehouse_Management.Model;
using Warehouse_Management.ViewModel.Base;
using Warehouse_Management.ViewModel.MapItems;

namespace Warehouse_Management.ViewModel
{
    using R = Properties.Resources;

    internal class MapVM : BaseViewModel
    {
        #region Props

        private BitmapImage mapImage;

        public BitmapImage MapImage
        {
            get { return mapImage; }
            set
            {
                mapImage = value;
                OnPropertyChanged(nameof(MapImage));
            }
        }

        private ObservableCollection<BaseItem> mapItems = new ObservableCollection<BaseItem>();

        public ObservableCollection<BaseItem> MapItems
        {
            get { return mapItems; }
            set
            {
                mapItems = value;
                OnPropertyChanged(nameof(MapItems));
            }
        }

        #endregion Props

        public MapVM()
        {
            mapImage = ByteArrayConverter.byteArrayToBitmap(R.PolandMapHQ);
            MapItems.Add(new WarehouseItem() { Left = 100, Top = 400 });
        }

        #region Private methods


        

        #endregion Private methods
    }
}