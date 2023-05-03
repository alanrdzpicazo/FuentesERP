﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.DCC;
using ProbeMedic.CATALOGOS;


using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace ProbeMedic
{
    public partial class FRM_GEO : Forma
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInicial;
        double LngIncial;

        public bool Nuevo_ = false;


        public FRM_GEO(double Lat, double Lng, String Direccion,bool Nuevo)
        {
            InitializeComponent();
            LatInicial = Lat;
            LngIncial = Lng;
            Nuevo_ = Nuevo;
            if (Nuevo == true)
            {
                txtDireccion.Text = Direccion;

            }
        }

        private void FRM_GEO_Load(object sender, EventArgs e)
        {

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngIncial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;

            //MARCADOR
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngIncial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            //AGREGAMOS UN TOOLTIP DE TEXTO A LOS MARCADORES
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", LatInicial, LngIncial);

            //AGREGAMOS EL MAPA Y EL MARCADOR AL MAP CONTROL
            gMapControl1.Overlays.Add(markerOverlay);

            txtLatitud.Text = LatInicial.ToString();
            txtLongitud.Text = LngIncial.ToString();

            if (Nuevo_ == true)
            {
                Inicializar();
                BuscarDireccion();
            }
            else
            {
                BuscarDireccion();
            }

            txtDireccion.Focus();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var json = new WebClient().DownloadString("http://maps.googleapis.com/maps/api/geocode/json?address=" + txtDireccion.Text+ "&key = AIzaSyDo_qFlATMKVSzfCqVp_rwqe5Jsztz62QI");
                Example obj = JsonConvert.DeserializeObject<Example>(json);

                txtLatitud.Text = obj.results[0].geometry.location.lat.ToString();
                txtLongitud.Text = obj.results[0].geometry.location.lng.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text),Convert.ToDouble(txtLongitud.Text));
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;

            //MARCADOR
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text)), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa


            //AGREGAMOS UN TOOLTIP DE TEXTO A LOS MARCADORES
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", txtLatitud.Text, txtLongitud.Text);

            //AGREGAMOS EL MAPA Y EL MARCADOR AL MAP CONTROL
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = string.Empty;
            txtDireccion.Focus();
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //SE OBTIENEN LOS DATOS DE LATITUD Y LONGITUD QUE EL USUARIO SELECCIONO
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //SE ASIGNAN EN LOS TEXTBOX LOS VALORES DE LATIDUD Y LONGITUD
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            BuscarDireccion();

            //CREAMOS EL MARCADOR PARA MOVERLO AL LUGAR ADECUADO
            marker.Position = new PointLatLng(lat, lng);

            //TAMBIEN SE AGREGA EL MENSAJE AL MARCADOR(TOOLTIP)
            marker.ToolTipText = string.Format("Ubicación:\n Latitud: {0} \n Longitud: {1}", lat, lng);
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
        }

        private void btnRelieve_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {                 
            this.Close();      
        }

        public void BuscarDireccion()
        {
            try
            {
                var json = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/geocode/json?latlng=" + txtLatitud.Text + "," + txtLongitud.Text + "&key=AIzaSyDo_qFlATMKVSzfCqVp_rwqe5Jsztz62QI");
                Example obj = JsonConvert.DeserializeObject<Example>(json);
                txtDireccion.Text = obj.results[0].formatted_address;
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }       
        }

        public void Inicializar()
        {
            try
            {
                var json = new WebClient().DownloadString("http://maps.googleapis.com/maps/api/geocode/json?address=" + txtDireccion.Text + "&key = AIzaSyDo_qFlATMKVSzfCqVp_rwqe5Jsztz62QI");
                Example obj = JsonConvert.DeserializeObject<Example>(json);

                //txtLatitud.Text = Math.Round(obj.results[0].geometry.location.lat, 6).ToString();
                //txtLongitud.Text = Math.Round(obj.results[0].geometry.location.lng, 6).ToString();
                txtLatitud.Text = obj.results[0].geometry.location.lat.ToString();
                txtLongitud.Text = obj.results[0].geometry.location.lng.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;

            //MARCADOR
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text)), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa


            //AGREGAMOS UN TOOLTIP DE TEXTO A LOS MARCADORES
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", txtLatitud.Text, txtLongitud.Text);

            //AGREGAMOS EL MAPA Y EL MARCADOR AL MAP CONTROL
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbZoom.Value = Convert.ToInt32(gMapControl1.Zoom);
        }

        private void tbZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = tbZoom.Value;
        }

       
    }
    }

