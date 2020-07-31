using LaboratorijskiKolokvijum.BusinessLayer;
using LaboratorijskiKolokvijum.BusinessLayer.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorijskiKolokvijum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateGridView();
            InitializeDropDowns();
        }

        private void InitializeDropDowns()
        {
            var getAlbumsOperation = new GetAlbumbsOperation();
            var getMediaTypesOperation = new GetMediaTypesOperation();
            var getGenresOperation = new GetGenresOperation();

            var albums = getAlbumsOperation.Execute().Data as IEnumerable<AlbumDto>;
            var mediaTypes = getMediaTypesOperation.Execute().Data as IEnumerable<MediaTypeDto>;
            var genres = getGenresOperation.Execute().Data as IEnumerable<GenreDto>;

            PopulateDropDown(ddlAlbum, albums);
            PopulateDropDown(ddlMediaType, mediaTypes);
            PopulateDropDown(ddlGenre, genres);
        }

        private void PopulateDropDown(ComboBox c, IEnumerable<object> items)
        {
            c.DisplayMember = "Name";
            c.ValueMember = "Id";
            c.DataSource = items;
        }
        private void PopulateGridView()
        {
            var songs = GetSongs();
            this.dgvSongs.DataSource = songs;
        }
        private IEnumerable<SongDto> GetSongs()
        {
            var getSongsOperation = new GetSongsOperation();

            var result = getSongsOperation.Execute().Data as IEnumerable<SongDto>;

            return result;
            
            #region Hardcode
            //return new List<SongDto>
            //{
            //    new SongDto
            //    {
            //        Id=5,
            //        AlbumName="Album 1",
            //        ArtistName = "Artist 1",
            //        MediaType = "mp3",
            //        Name="Name 1",
            //        Price = 100,
            //        SoldItems = 5,
            //        PlaylistNames = new List<string>
            //        {
            //            "Playlist 1",
            //            "Playlist 2"
            //        }


            //    }
            //}; 
            #endregion
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rowIndex = this.dgvSongs.SelectedCells[0].RowIndex;
            var row = this.dgvSongs.Rows[rowIndex];
            var dto = row.DataBoundItem as SongDto;

            var deleteSong = new DeleteSongOperation(dto.Id);

            try
            {
                deleteSong.Execute();
                MessageBox.Show("Uspesno obrisano");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            var dto = new CreateSongDto();

            dto.SongName = tbName.Text;
            dto.Composer = tbComposer.Text;

            dto.AlbumId = (ddlAlbum.SelectedItem as AlbumDto).Id;
            dto.MediaTypeId = (ddlMediaType.SelectedItem as MediaTypeDto).Id;
            dto.GenreId = (ddlGenre.SelectedItem as GenreDto).Id;

            dto.Price = songPrice.Value;


            var operation = new AddSongOperation(dto);

            try
            {
                operation.Execute();
                MessageBox.Show("USpesan unos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }








        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
