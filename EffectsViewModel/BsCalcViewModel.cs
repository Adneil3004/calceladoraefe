using EffectsModeldata;
using EffectsViewModel.Herramientas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Input;

namespace EffectsViewModel
{
    public class BsCalcViewModel : Herramientas.NotifyBase
    {

        public BsCalcViewModel()
        {
            espcecialcomad = new Herramientas.command(ejecutar(), null);

            ResIntemedios = new DataTable();
            ResIntemedios.Clear();
            ResIntemedios.Columns.Add("No", typeof(string));
            ResIntemedios.Columns.Add("Xp", typeof(string));
            ResIntemedios.Columns.Add("APE", typeof(string));
            ResIntemedios.Columns.Add("DeltaT", typeof(string));
            ResIntemedios.Columns.Add("Tx", typeof(string));
            ResIntemedios.Columns.Add("Ta", typeof(string));
            ResIntemedios.Columns.Add("HL", typeof(string));
            ResIntemedios.Columns.Add("He", typeof(string));
            ResIntemedios.Columns.Add("[]", typeof(string));
        }

        private BaseCalcModel _BasesCalc=new BaseCalcModel();
        private CoefTranCalModel _CTM= new CoefTranCalModel(); 
        private ConcetracionesModel _ConcenModel  = new ConcetracionesModel();
        private CPModel _CP = new CPModel();
        private PresionModel _Presion = new PresionModel();
        private TemperaturaModel _Temp = new TemperaturaModel();
        private TiposVaporModel _tvap = new TiposVaporModel();
        private TipoSol _tsol = new TipoSol();
        private Tarrego _tarrego;
        private ObservableCollection<Tarrego> _tarregos;
        private Herramientas.command _espcecialcomad;
        private resultados _resultados;
        private DataTable _ResIntemedios;

        public BaseCalcModel BaseCalc
        {
            get => _BasesCalc;
            set
            {
                _BasesCalc = value;
                OnPropertyChanged("BaseCalc");
            }
        }
        public CoefTranCalModel CTM
        {
            get => _CTM;
            set
            {
                _CTM = value;
                OnPropertyChanged("CTM");
            }
        }
        public ConcetracionesModel ConcenModel
        {
            get => _ConcenModel;
            set
            {
                _ConcenModel = value;
                OnPropertyChanged("ConcenModel");
            }

        }
        public CPModel CP
        {
            get => _CP;
            set
            {
                _CP = value;
                OnPropertyChanged("CP");
            }
        }
        public PresionModel Presion

        {
            get => _Presion;
            set
            {
                _Presion = value;
                OnPropertyChanged("Presion");
            }
        }
        public TemperaturaModel Temp
        {
            get => _Temp;
            set
            {
                _Temp = value;
                OnPropertyChanged("TemP");
            }
        }
        public TiposVaporModel tvap
        {
            get => _tvap;
            set
            {
                _tvap = value;
                OnPropertyChanged("tvap");
            }
        }
        public TipoSol tsol
        {
            get => _tsol;
            set
            {
                _tsol = value;
                OnPropertyChanged("tsol");
            }
        }
        public Tarrego Tarrego
        {
            get => _tarrego;
            set
            {
                _tarrego = value;
                OnPropertyChanged("Tarrego");
            }
        }
        public ObservableCollection<Tarrego> Tarregos
        {
            get
            {
                return _tarregos;
            }
            set
            {
                _tarregos = value;
                OnPropertyChanged("Tarregos");
            }
        }
        public command espcecialcomad
        public resultados resultados
        {
            get => _resultados;
            set
            {
                _resultados = value;
                OnPropertyChanged("resultados");

            }
        }

        {
            get
            {
                return _espcecialcomad ;
            }
            set
            {
                _espcecialcomad = value;
                
            }
        }


        public double MA
        {
            get => BaseCalc.BaseMA;
            set
            {
                BaseCalc.BaseMA = value;
                OnPropertyChanged("MA");
            }
        }
        public double MP
        {
            get => _BasesCalc.BaseMP;
            set
            {
                _BasesCalc.BaseMP = value;
                OnPropertyChanged("MA");
            }
        }

        public double u1
        {
            get => _CTM.CoefU1;
            set
            {

                _CTM.CoefU1 = value;
                OnPropertyChanged("u1");
            }
        }
        public double u2
        {
            get => _CTM.CoefU2;
            set
            {

                _CTM.CoefU2 = value;
                OnPropertyChanged("u2");
            }
        }
        public double u3
        {
            get => _CTM.CoefU3;
            set
            {

                _CTM.CoefU3 = value;
                OnPropertyChanged("u3");
            }
        }
        public double u4
        {
            get => _CTM.CoefU4;
            set
            {

                _CTM.CoefU4 = value;
                OnPropertyChanged("u4");
            }
        }

        public double XA
        {
            get => _ConcenModel.InicialXA;
            set
            {
                ConcenModel.InicialXA = value;
                OnPropertyChanged("XA");
            }
        }
        public double XP
        {
            get => ConcenModel.FinalXP;
            set
            {
                _ConcenModel.FinalXP = value;
                OnPropertyChanged("XP");
            }
        }

        public double val1
        {
            get => _CP.CPval1;
            set
            {
                _CP.CPval1 = value;
                OnPropertyChanged("val1");
            }
        }
        public double val2
        {
            get => _CP.CPval2;
            set
            {
                _CP.CPval2 = value;
                OnPropertyChanged("val2");
            }
        }

        public double PresC
        {
            get => Presion.PresionC;
            set
            {
                Presion.PresionC = value;
                OnPropertyChanged("PresC");
            }
        }
        public double PresEV
        {
            get => Presion.PresionEV;
            set
            {
                Presion.PresionEV = value;
                OnPropertyChanged("PresEV");
            }
        }
        public double PresV
        {
            get => Presion.PresionV;
            set
            {
                Presion.PresionV = value;
                OnPropertyChanged("PresV");
            }
        }

        public double TA
        {
            get => Temp.TemA;
            set
            {
                Temp.TemA = value;
                OnPropertyChanged("TA");
            }
        }
        public double TC
        {
            get => Temp.TemC;
            set
            {
                Temp.TemC = value;
                OnPropertyChanged("TC");
            }
        }
        public double TV
        {
            get => Temp.TemV;
            set
            {
                Temp.TemV = value;
                OnPropertyChanged("TV");
            }
        }
        public double TW
        {
            get => Temp.TemWater;
            set
            {
                Temp.TemWater = value;
                OnPropertyChanged("TW");
            }
        }

        public double tscv
        {
            get => tvap.Tscv;
            set
            {
                tvap.Tscv = value;
                OnPropertyChanged("tscv");
            }
        }
        public double calidad
        {
            get => tvap.Calidad;
            set
            {
                tvap.Calidad = value;
                OnPropertyChanged("calidad");
            }
        }
        public double perdida
        {
            get => tvap.Perdidas;
            set
            {
                tvap.Perdidas = value;
                OnPropertyChanged("perdida");
            }
        }
        public double humedad
        {
            get => tvap.Humedad;
            set
            {
                tvap.Humedad = value;
                OnPropertyChanged("humedad");
            }
        }

        public bool Naoh
        {
            get
            {
                return tsol.NAOH;
            }
            set
            {
                tsol.NAOH = value;
                OnPropertyChanged("Naoh");
            }
        }
        public bool organica
        {
            get
            {
                return tsol.Organica;
            }
            set
            {
                tsol.Organica = value;
                OnPropertyChanged("organica");
            }
        }
        public bool inorg
        {
            get
            {
                return tsol.Inprganica;
            }
            set
            {
                tsol.Inprganica = value;
                OnPropertyChanged("inorg");
            }
        }
        public double PM
        {
            get => tsol.PM1;
            set
            {
                tsol.PM1 = value;
                OnPropertyChanged("PM");
            }
        }
        public string arreglo

        {
            get => tsol.Arreglo;
            set
            {
                tsol.Arreglo = value;
                OnPropertyChanged("arreglo");
            }
        }
        public int noefects

        {
            get => tsol.NoEfectos;
            set
            {
                tsol.NoEfectos = value;
                OnPropertyChanged("arreglo");
            }
        }

        public DataTable ResIntemedios
        {
            get => _ResIntemedios;
            set
            {
                _ResIntemedios = value;
                OnPropertyChanged("ResIntemedios");
            }
        }

        public resultados Resultados { get => _resultados; set => _resultados = value; }

        public Action<object> ejecutar()

        {
            Action<object> obj = new Action<object>(o=> desarrollefects( Convert.ToInt32(arreglo)));
            return obj;
        }
        public DataTable cargaArreglos3efect()
        {
            noefects = 3;
            DataTable dt = new DataTable();
            Herramientas.Consulta arreglos = new Herramientas.Consulta();
            dt = arreglos.cargaConsulta("select idArreglo, TipoEfecto, Configuracion from t_Arreglos3Efect");
            return dt;
        }
        public DataTable cargaArreglos4efect()
        {
            noefects = 4;
            DataTable dt = new DataTable();
            Herramientas.Consulta arreglos = new Herramientas.Consulta();
            dt = arreglos.cargaConsulta("select idEfecto, TipoEfecto, Configuracion from t_Arreglos4Efect");

            return dt;

        }

        public Double[]  calculoDeConcetraciones(double XA, double XP, int Arreglo)
        {
            
            DataTable dtrecorrido = new DataTable();
            dtrecorrido = new Herramientas.Consulta().cargaConsulta("select idRecorrido, TipoRec, z1, z2, z3, z4 from t_Recorridos4Efec where idRecorrido = " + Arreglo);
            noefects = dtrecorrido.Columns.Count-2;
            int[] z = new int[noefects];
            for (int i = 3; i < dtrecorrido.Columns.Count; i++)
            {
                z[i - 3] = Convert.ToInt32(dtrecorrido.Rows[0][i].ToString());
            }
            double[] calculadaXp = new double[noefects];

            for (int i = 0; i < noefects; i++)
            {
                calculadaXp[i] = XA / (1) / (1 - (z[i] / noefects) * ((XP - XA) / XP));
            }

            return calculadaXp;
        }

        
        public void desarrollefects( int arreglo)
        {
            if (arreglo== 0)
                return;

            double[] calculadaXp = calculoDeConcetraciones(XA, XP, arreglo);

            double tx1 = 0;
            double tx2 = 0;
            double tx3 = 0;
            double tx4 = 0;

            double ape1 = 0;
            double ape2 = 0;
            double ape3 = 0;
            double ape4 = 0;

            double callat1 = 0;
            double callat2 = 0;
            double callat3 = 0;
            double callat4 = 0;

            double Hv1 = 0;
            double Hv2 = 0;
            double Hv3 = 0;
            double Hv4 = 0;

            double Hl1 = 0;
            double Hl2 = 0;
            double Hl3 = 0;
            double Hl4 = 0;
            double HA = 0;

            double ta1 = 0;
            double ta2 = 0;
            double ta3 = 0;
            double ta4 = 0;

            double He1 = 0;
            double He2 = 0;
            double He3 = 0;
            double He4 = 0;

            double Ha1 = 0;
            double Ha2 = 0;
            double Ha3 = 0;
            double Ha4 = 0;

            double Xa1 = 0;
            double Xa2 = 0;
            double Xa3 = 0;
            double Xa4 = 0;

            double e1 = 0;
            double e2 = 0;
            double e3 = 0;
            double e4 = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;

            double x1 = 0;
            double x2 = 0;
            double x3 = 0;
            double x4 = 0;

            double a1 = 0;
            double a2 = 0;
            double a3 = 0;
            double a4 = 0;

            double error = 0;
            double am = 0;

            double[] At = new double[noefects];
            double[] Noname = new double[noefects];
            double EAPE = 0;
            if (noefects == 4)
            {

                if (Naoh==true)
                {
                    ta1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Ta1").ToString());
                    ta2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Ta2").ToString());
                    ta3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Ta3").ToString());
                    ta4 = 0;
                    tx4 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Ta4").ToString());
                    tx1 = TV - 20;
                    ape1 = tx1 - ta1;
                    tx2 = ta1 - 20;
                    ape2 = tx2 - ta2;
                    tx3 = ta2 - 20;
                    ape3 = tx3 - ta3;

                    DataTable valt4 = new DataTable();
                    valt4 = new Herramientas.Consulta().cargaConsulta("select temperatura_vapor from t_vapor where presion_vapor>=" + PresEV + " limit 1");
                    ta4 = Convert.ToDouble(valt4.Rows[0][0].ToString());

                    ape4 = tx4 = ta4;

                    EAPE = ape1 + ape2 + ape3 + ape4;

                    At = CalculoTs(ta4, EAPE, noefects);

                    tx1 = TV - At[0];
                    ta1 = tx1 - ape1;
                    tx2 = TV - At[1];
                    ta2 = tx1 - ape2;
                    tx3 = TV - At[2];
                    ta3 = tx1 - ape3;
                    tx4 = TV - At[3];
                    ta4 = tx1 - ape4;

                    DataTable dt_ta = new DataTable();
                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta1 + "  limit 1");
                    callat1 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv1 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta2 + "  limit 1");
                    callat2 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv2 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta3 + "  limit 1");
                    callat3 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta4 + "  limit 1");
                    callat4 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    Hl1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HL1"));
                    Hl2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HL2"));
                    Hl3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HL3"));
                    Hl4 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HL4"));
                    HA = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HA"));
                }
                else if (inorg==true)
                {


                    ape1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa APE 1"));
                    ape2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa APE 2"));
                    ape3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa APE 3"));
                    ape4 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa APE 4"));

                    tx1 = TV - 20;
                    ta1 = tx1 - ape1;

                    tx2 = ta1 - 20;
                    ta2 = tx2 - ape2;

                    tx3 = ta2 - 20;
                    ta3 = tx3 - ape3;

                    DataTable valt4 = new DataTable();
                    valt4 = new Herramientas.Consulta().cargaConsulta("select temperatura_vapor from t_vapor where presion_vapor>=" + PresEV + " limit 1");
                    ta4 = Convert.ToDouble(valt4.Rows[0][0].ToString());

                    tx4 = ta4 - ape4;

                    EAPE = ape1 + ape2 + ape3 + ape4;

                    At = CalculoTs(ta4, EAPE, noefects);

                    tx1 = TV - At[0];
                    ta1 = tx1 - ape1;
                    tx2 = TV - At[1];
                    ta2 = tx1 - ape2;
                    tx3 = TV - At[2];
                    ta3 = tx1 - ape3;
                    tx4 = TV - At[3];
                    ta4 = tx1 - ape4;

                    DataTable dt_ta = new DataTable();
                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta1 + "  limit 1");
                    callat1 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv1 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta2 + "  limit 1");
                    callat2 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv2 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta3 + "  limit 1");
                    callat3 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta4 + "  limit 1");
                    callat4 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();


                    Hl1 = (val1 * calculadaXp[1] + val2 * tx1) * tx1;
                    Hl2 = (val1 * calculadaXp[2] + val2 * tx2) * tx2;
                    Hl3 = (val1 * calculadaXp[3] + val2 * tx3) * tx3;
                    Hl4 = (val1 * calculadaXp[4] + val2 * tx4) * tx4;
                    HA = (val1 * XA + val2 * TA) * TA;


                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta1 + "  limit 1");
                    callat1 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv1 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta2 + "  limit 1");
                    callat2 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv2 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta3 + "  limit 1");
                    callat3 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta4 + "  limit 1");
                    callat4 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();
                }
                else//organica
                {


                    calculadaXp = calculoDeConcetraciones(XA, XP, arreglo);

                    tx1 = TV - 20;
                    x1 = (1 - calculadaXp[1] / 18) / ((1 - calculadaXp[1] / 18) + (calculadaXp[1] / PM));
                    DataTable dt_ta = new DataTable();
                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  presion_vapor  FROM t_vapor WHERE temperatura_vapor >= " + tx1 + " limit 1");
                    p1 = Convert.ToDouble(dt_ta.Rows[0][0].ToString()) * x1;
                    dt_ta.Dispose();


                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + p1 + " limit 1");
                    ta1 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    ape1 = tx1 - ta1;

                    //
                    tx2 = ta1 - 20;
                    x2 = (1 - calculadaXp[2] / 18) / ((1 - calculadaXp[2] / 18) + (calculadaXp[2] / PM));

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  presion_vapor  FROM t_vapor WHERE temperatura_vapor >= " + tx2 + " limit 1");
                    p2 = Convert.ToDouble(dt_ta.Rows[0][0].ToString()) * x2;
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + p2 + " limit 1");
                    ta2 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    ape2 = tx2 - ta2;

                    tx3 = ta2 - 20;
                    x3 = (1 - calculadaXp[3] / 18) / ((1 - calculadaXp[3] / 18) + (calculadaXp[3] / PM));

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  presion_vapor  FROM t_vapor WHERE temperatura_vapor >= " + tx3 + " limit 1");
                    p3 = Convert.ToDouble(dt_ta.Rows[0][0].ToString()) * x3;
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + p3 + " limit 1");
                    ta3 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    ape3 = tx3 - ta3;

                    x4 = (1 - calculadaXp[4] / 18) / ((1 - calculadaXp[4] / 18) + (calculadaXp[4] / PM));
                    p4 = PresEV / x4;

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + PresEV + " limit 1");
                    ta4 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + p4 + " limit 1");
                    tx4 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    ape4 = tx4 - ta4;

                    EAPE = ape1 + ape2 + ape3 + ape4;

                    At = CalculoTs(ta4, EAPE, noefects);

                    tx1 = TV - At[0];
                    ta1 = tx1 - ape1;
                    tx2 = TV - At[1];
                    ta2 = tx1 - ape2;
                    tx3 = TV - At[2];
                    ta3 = tx1 - ape3;
                    tx4 = TV - At[3];
                    ta4 = tx1 - ape4;

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta1 + "  limit 1");
                    callat1 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv1 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta2 + "  limit 1");
                    callat2 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv2 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta3 + "  limit 1");
                    callat3 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta4 + "  limit 1");
                    callat4 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    Hl1 = (val1 * calculadaXp[1] + val2 * tx1) * tx1;
                    Hl2 = (val1 * calculadaXp[2] + val2 * tx2) * tx2;
                    Hl3 = (val1 * calculadaXp[3] + val2 * tx3) * tx3;
                    Hl4 = (val1 * calculadaXp[4] + val2 * tx4) * tx4;
                    HA = (val1 * XA + (val2 * TA)) * TA;
                }

                He1 = Hv1 * 0.45 * ape1;
                He2 = Hv2 * 0.45 * ape4;
                He3 = Hv3 * 0.45 * ape3;
                He4 = Hv4 * 0.45 * ape4;

                Noname[0] = He1 + (((Hl1 * Xa1) - (Ha1 - calculadaXp[0])) / (calculadaXp[0] - Xa1));
                Noname[1] = He1 + (((Hl2 * Xa2) - (Ha2 - calculadaXp[1])) / (calculadaXp[1] - Xa2));
                Noname[2] = He1 + (((Hl3 * Xa3) - (Ha3 - calculadaXp[2])) / (calculadaXp[2] - Xa3));
                Noname[3] = He1 + (((Hl1 * Xa4) - (Ha1 - calculadaXp[3])) / (calculadaXp[3] - Xa4));

                double ET = MA - MP;

                e2 = ET / (Noname[1] / ((callat1 + 0.45 * ape1)) + 1 + ((callat2 + 0.45 * ape2) / Noname[2]) + (((callat2 + 0.45 * ape2) * (callat2 + 0.45 * ape2)) / (Noname[2] * Noname[4])));
                e1 = (e2 * Noname[1]) / (callat1 + 0.45 * ape1);
                e3 = (e2 * (callat2 + 0.45 * ape2)) / Noname[2];
                e4 = (e3 * (callat3 + 0.45 * ape3)) / Noname[3];

                a1 = e1 * Noname[0] / u1 * At[0];
                a2 = e2 * Noname[1] / u2 * At[1];
                a3 = e3 * Noname[2] / u3 * At[2];
                a4 = e4 * Noname[3] / u4 * At[3];

                am = (a1 + a2 + a3 + a4) / 4;
                double[] area = new double[4];
                area[0] = a1;
                area[1] = a2;
                area[2] = a3;
                area[3] = a4;
                double amax = 0;
                for (int i = 0; i < area.Length; i++)
                {
                    if (area[i] > amax)
                        amax = area[i];
                }
                error = ((amax - am) / am) * 100;

                ResIntemedios.Rows.Add("1", calculadaXp[0], ape1, At[1], tx1, ta1, Hl1, He1, Noname[0]);
                ResIntemedios.Rows.Add("2", calculadaXp[1], ape2, At[1], tx2, ta2, Hl2, He2, Noname[1]);
                ResIntemedios.Rows.Add("3", calculadaXp[2], ape3, At[1], tx3, ta3, Hl3, He3, Noname[2]);
                ResIntemedios.Rows.Add("4", calculadaXp[3], ape4, At[1], tx4, ta4, Hl4, He4, Noname[3]);
                //calculo tx y ta

            }

            else
            {
                //effectos
                if (Naoh == true)
                {
                    ta1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Ta1"));
                    ta2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Ta2"));
                    ta3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Ta3"));

                    tx3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa Tx 3"));
                    tx1 = TV - 20;
                    ape1 = tx1 - ta1;
                    tx2 = ta1 - 20;
                    ape2 = tx2 - ta2;
                    tx3 = ta2 - 20;
                    ape3 = tx3 - ta3;

                    DataTable valt4 = new DataTable();
                    valt4 = new Herramientas.Consulta().cargaConsulta("select temperatura_vapor from t_vapor where presion_vapor>=" + PresEV + " limit 1");
                    ta3 = Convert.ToDouble(valt4.Rows[0][0].ToString());

                    ape3 = tx3 = ta3;

                    EAPE = ape1 + ape2 + ape3;

                    At = CalculoTs(ta4, EAPE, noefects);

                    tx1 = TV - At[0];
                    ta1 = tx1 - ape1;
                    tx2 = ta1 - At[1];
                    ta2 = tx2 - ape2;
                    tx3 = ta2 - At[2];
                    ta3 = tx3 - ape3;
                    tx4 = ta3 - At[3];
                    ta4 = tx4 - ape4;

                    DataTable dt_ta = new DataTable();
                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta1 + "  limit 1");
                    callat1 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv1 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta2 + "  limit 1");
                    callat2 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv2 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta3 + "  limit 1");
                    callat3 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta4 + "  limit 1");
                    callat4 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    Hl1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HL1"));
                    Hl2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HL2"));
                    Hl3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HL3"));
                    Hl4 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HL4"));
                    HA = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa HA"));
                }
                else if (inorg == true)
                {


                    ape1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa APE 1"));
                    ape2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa APE 2"));
                    ape3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa APE 3"));


                    tx1 = TV - 20;
                    ta1 = tx1 - ape1;

                    tx2 = ta1 - 20;
                    ta2 = tx2 - ape2;

                    tx3 = ta2 - 20;
                    ta3 = tx3 - ape3;

                    DataTable valt4 = new DataTable();
                    valt4 = new Herramientas.Consulta().cargaConsulta("select temperatura_vapor from t_vapor where presion_vapor>=" + PresEV + " limit 1");
                    ta3 = Convert.ToDouble(valt4.Rows[0][0].ToString());

                    tx3 = ta3 - ape3;

                    EAPE = ape1 + ape2 + ape3;

                    At = CalculoTs(ta4, EAPE, noefects);

                    tx1 = TV - At[0];
                    ta1 = tx1 - ape1;
                    tx2 = ta1 - At[1];
                    ta2 = tx2 - ape2;
                    tx3 = ta2 - At[2];
                    ta3 = tx3 - ape3;


                    DataTable dt_ta = new DataTable();
                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta1 + "  limit 1");
                    callat1 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv1 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta2 + "  limit 1");
                    callat2 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv2 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta3 + "  limit 1");
                    callat3 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();




                    Hl1 = (val1 * calculadaXp[0] + val2 * tx1) * tx1;
                    Hl2 = (val1 * calculadaXp[1] + val2 * tx2) * tx2;
                    Hl3 = (val1 * calculadaXp[2] + val2 * tx3) * tx3;


                    HA = (val1 * XA + val2 * TA) * TA;


                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta1 + "  limit 1");
                    callat1 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv1 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta2 + "  limit 1");
                    callat2 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv2 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta3 + "  limit 1");
                    callat3 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv4 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();


                }
                else//organica
                {

                    calculadaXp = calculoDeConcetraciones(XA, XP, arreglo);

                    tx1 = TV - 20;
                    x1 = (1 - calculadaXp[1] / 18) / ((1 - calculadaXp[1] / 18) + (calculadaXp[1] / PM));
                    DataTable dt_ta = new DataTable();
                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  presion_vapor  FROM t_vapor WHERE temperatura_vapor >= " + tx1 + " limit 1");
                    p1 = Convert.ToDouble(dt_ta.Rows[0][0].ToString()) * x1;
                    dt_ta.Dispose();


                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + p1 + " limit 1");
                    ta1 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    ape1 = tx1 - ta1;

                    //
                    tx2 = ta1 - 20;
                    x2 = (1 - calculadaXp[2] / 18) / ((1 - calculadaXp[2] / 18) + (calculadaXp[2] / PM));

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  presion_vapor  FROM t_vapor WHERE temperatura_vapor >= " + tx2 + " limit 1");
                    p2 = Convert.ToDouble(dt_ta.Rows[0][0].ToString()) * x2;
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + p2 + " limit 1");
                    ta2 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    ape2 = tx2 - ta2;


                    tx3 = ta2 - 20;
                    x3 = (1 - calculadaXp[3] / 18) / ((1 - calculadaXp[3] / 18) + (calculadaXp[3] / PM));
                    p3 = PresEV / x4;

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + PresEV + " limit 1");
                    ta3 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT  temperatura_vapor  FROM t_vapor WHERE presion_vapor >= " + p4 + " limit 1");
                    tx3 = Convert.ToDouble(dt_ta.Rows[0][0].ToString());
                    dt_ta.Dispose();

                    ape3 = tx3 - ta3;

                    EAPE = ape1 + ape2 + ape3;

                    At = CalculoTs(ta4, EAPE, noefects);

                    tx1 = TV - At[0];
                    ta1 = tx1 - ape1;
                    tx2 = ta1 - At[1];
                    ta2 = tx2 - ape2;
                    tx3 = ta2 - At[2];
                    ta3 = tx3 - ape3;


                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta1 + "  limit 1");
                    callat1 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv1 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta2 + "  limit 1");
                    callat2 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv2 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();

                    dt_ta = new Herramientas.Consulta().cargaConsulta("SELECT entalpia_vapor, calor_latente   FROM t_vapor WHERE temperatura_vapor >= " + ta3 + "  limit 1");
                    callat3 = Convert.ToDouble(dt_ta.Rows[0][1].ToString());
                    Hv3 = Convert.ToDouble(dt_ta.Rows[0][2].ToString());
                    dt_ta.Dispose();



                    Hl1 = (val1 * calculadaXp[0] + val2 * tx1) * tx1;
                    Hl2 = (val1 * calculadaXp[1] + val2 * tx2) * tx2;
                    Hl3 = (val1 * calculadaXp[2] + val2 * tx3) * tx3;


                    HA = (val1 * XA + (val2 * TA)) * TA;
                }

                He1 = Hv1 * 0.45 * ape1;
                He2 = Hv2 * 0.45 * ape4;
                He3 = Hv3 * 0.45 * ape3;
                He4 = Hv4 * 0.45 * ape4;

                Noname[0] = He1 + (((Hl1 * Xa1) - (Ha1 - calculadaXp[0])) / (calculadaXp[0] - Xa1));
                Noname[1] = He1 + (((Hl2 * Xa2) - (Ha2 - calculadaXp[1])) / (calculadaXp[1] - Xa2));
                Noname[2] = He1 + (((Hl3 * Xa3) - (Ha3 - calculadaXp[2])) / (calculadaXp[2] - Xa3));


                double ET = MA - MP;

                e2 = ET / (Noname[1] / ((callat1 + 0.45 * ape1)) + 1 + ((callat2 + 0.45 * ape2) / Noname[2])); e1 = (e2 * Noname[1]) / (callat1 + 0.45 * ape1);
                e1 = (e2 * Noname[1]) / (callat1 + 0.45 * ape1);
                e3 = (e2 * (callat2 + 0.45 * ape2)) / Noname[2];

                a1 = e1 * Noname[0] / u1 * At[0];
                a2 = e2 * Noname[1] / u2 * At[1];
                a3 = e3 * Noname[2] / u3 * At[2];


                am = (a1 + a2 + a3) / 3;
                double[] area = new double[3];
                area[0] = a1;
                area[1] = a2;
                area[2] = a3;

                double amax = 0;
                for (int i = 0; i < area.Length; i++)
                {
                    if (area[i] > amax)
                        amax = area[i];
                }
                error = ((amax - am) / am) * 100;

                ResIntemedios.Rows.Add("1", calculadaXp[0], ape1, At[1], tx1, ta1, Hl1, He1, Noname[0]);
                ResIntemedios.Rows.Add("2", calculadaXp[1], ape2, At[1], tx2, ta2, Hl2, He2, Noname[1]);
                ResIntemedios.Rows.Add("3", calculadaXp[2], ape3, At[1], tx3, ta3, Hl3, He3, Noname[2]);

                //calculo tx y ta



            }


        }

        public Double calculoUM(int noefects)
        {
            double um = 0;
            if (noefects == 4)
            {
                um = 1 / (1 / u1) + (1 / u2) + (1 / u3) + (1 / u4);

            }
            else
            {
                um = 1 / (1 / u1) + (1 / u2) + (1 / u3);

            }
            return um;
        }

        public double calculoATt(double ta4, double totalAPE)
        {

            double TT = 0;
            TT = TV - ta4 - totalAPE;
            return TT;
        }

        public double[] CalculoTs(double ta4, double totalAPE, int noefects)
        {
            double UM = calculoUM(noefects);
            double tt = calculoATt(ta4, totalAPE);
            double[] At = new double[noefects];
            At[0] = (UM / u1) * tt;
            At[1] = (UM / u2) * tt;
            At[2] = (UM / u3) * tt;
            At[3] = (UM / u4) * tt;
            return At;

        }

        //comandos

       

    }

    
}
