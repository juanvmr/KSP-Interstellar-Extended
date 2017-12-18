﻿namespace FNPlugin.Extensions
{
	public class AtmosphericFloatCurves
	{
		public FloatCurve MassDensityAtmosphereGramPerCubeCm { get; private set; }
		public FloatCurve ParticlesAtmosphereCubePerMeter { get; private set; }
		public FloatCurve ParticlesHydrogenCubePerMeter { get; private set; }
		public FloatCurve ParticlesHeliumnPerCubePerCm { get; private set; }
		public FloatCurve HydrogenIonsPerCubeCm { get; private set; }

		public FloatCurve InterstellarDensity { get; private set; }

		private static AtmosphericFloatCurves _instance;

		public static AtmosphericFloatCurves Instance
		{
			get { return _instance ?? (_instance = new AtmosphericFloatCurves()); }
		}

		private AtmosphericFloatCurves()
		{
			InitializeAtmosphereParticles();
		}

		private void InitializeAtmosphereParticles()
		{
			InitializeDensityAtmosphereCubeCm();

			InitializeParticlesAtmosphereCurbeM();

			InitializeParticlesHydrogenCubeM();

            InitialiseParticlesHeliumnCubePerMeter();

			InitializeHydrogenIonsCubeCm();
		}

		private void InitializeInterstellarParticleDensity()
		{
			if (InterstellarDensity != null) return;

			InterstellarDensity = new FloatCurve();
			InterstellarDensity.Add(0, 0);
			InterstellarDensity.Add(79, 0.0f);
			InterstellarDensity.Add(80, 0.001f); // <== Termination Shock
			InterstellarDensity.Add(81, 0.002f);
			InterstellarDensity.Add(82, 0.004f);
			InterstellarDensity.Add(83, 0.008f);
			InterstellarDensity.Add(84, 0.016f);
			InterstellarDensity.Add(85, 0.03125f);
			InterstellarDensity.Add(86, 0.0625f);
			InterstellarDensity.Add(87, 0.125f);
			InterstellarDensity.Add(88, 0.25f);
			InterstellarDensity.Add(89, 0.5f);
			InterstellarDensity.Add(90, 1);  // <== Helio Pause
			InterstellarDensity.Add(91, 2);
			InterstellarDensity.Add(92, 4);
			InterstellarDensity.Add(93, 8);
			InterstellarDensity.Add(94, 16);
			InterstellarDensity.Add(95, 32);
			InterstellarDensity.Add(96, 64);
			InterstellarDensity.Add(97, 100); //<== Hydrogen Wall
			InterstellarDensity.Add(98, 33);
			InterstellarDensity.Add(99, 11);
			InterstellarDensity.Add(100, 1);
			InterstellarDensity.Add(10000, 1);
		}

		private void InitializeHydrogenIonsCubeCm()
		{
			if (HydrogenIonsPerCubeCm != null) return;

			HydrogenIonsPerCubeCm = new FloatCurve();
			HydrogenIonsPerCubeCm.Add(0, 0);
			HydrogenIonsPerCubeCm.Add(284, 0);
			HydrogenIonsPerCubeCm.Add(285, 1.00e+8f);
			HydrogenIonsPerCubeCm.Add(299, 2.49e+8f);
			HydrogenIonsPerCubeCm.Add(312, 4.40e+8f);
			HydrogenIonsPerCubeCm.Add(334, 6.34e+8f);
			HydrogenIonsPerCubeCm.Add(359, 8.83e+8f);
			HydrogenIonsPerCubeCm.Add(377, 1.11e+9f);
			HydrogenIonsPerCubeCm.Add(396, 1.26e+9f);
			HydrogenIonsPerCubeCm.Add(411, 1.36e+9f);
			HydrogenIonsPerCubeCm.Add(437, 1.51e+9f);
			HydrogenIonsPerCubeCm.Add(464, 1.65e+9f);
			HydrogenIonsPerCubeCm.Add(504, 1.78e+9f);
			HydrogenIonsPerCubeCm.Add(536, 1.86e+9f);
			HydrogenIonsPerCubeCm.Add(588, 2.00e+9f);
			HydrogenIonsPerCubeCm.Add(641, 2.20e+9f);
			HydrogenIonsPerCubeCm.Add(678, 2.40e+9f);
			HydrogenIonsPerCubeCm.Add(715, 2.64e+9f);
			HydrogenIonsPerCubeCm.Add(754, 2.94e+9f);
			HydrogenIonsPerCubeCm.Add(793, 3.33e+9f);
			HydrogenIonsPerCubeCm.Add(829, 3.76e+9f);
			HydrogenIonsPerCubeCm.Add(864, 4.26e+9f);
			HydrogenIonsPerCubeCm.Add(904, 4.97e+9f);
			HydrogenIonsPerCubeCm.Add(939, 5.72e+9f);
			HydrogenIonsPerCubeCm.Add(968, 6.43e+9f);
			HydrogenIonsPerCubeCm.Add(992, 7.07e+9f);
			HydrogenIonsPerCubeCm.Add(1010, 7.61e+9f);
			HydrogenIonsPerCubeCm.Add(1040, 7.95e+9f);
			HydrogenIonsPerCubeCm.Add(1070, 8.15e+9f);
			HydrogenIonsPerCubeCm.Add(1100, 8.13e+9f);
			HydrogenIonsPerCubeCm.Add(1140, 7.89e+9f);
			HydrogenIonsPerCubeCm.Add(1170, 7.57e+9f);
			HydrogenIonsPerCubeCm.Add(1190, 7.21e+9f);
			HydrogenIonsPerCubeCm.Add(1240, 6.46e+9f);
			HydrogenIonsPerCubeCm.Add(2000, 3.8e+7f);
			HydrogenIonsPerCubeCm.Add(4000, 1.9e+5f);
			HydrogenIonsPerCubeCm.Add(8000, 9.5e+2f);
			HydrogenIonsPerCubeCm.Add(10000, 0);
		}

		private void InitialiseParticlesHeliumnCubePerMeter()
		{
			if (ParticlesHeliumnPerCubePerCm != null) return;

			ParticlesHeliumnPerCubePerCm = new FloatCurve();

			ParticlesHeliumnPerCubePerCm.Add(0.0f, 1.462E+14f);
			ParticlesHeliumnPerCubePerCm.Add(10.0f, 4.503E+13f);
			ParticlesHeliumnPerCubePerCm.Add(20.0f, 9.351E+12f);
			ParticlesHeliumnPerCubePerCm.Add(30.0f, 1.757E+12f);
			ParticlesHeliumnPerCubePerCm.Add(40.0f, 3.558E+11f);
			ParticlesHeliumnPerCubePerCm.Add(50.0f, 9.383E+10f);
			ParticlesHeliumnPerCubePerCm.Add(60.0f, 2.611E+10f);
			ParticlesHeliumnPerCubePerCm.Add(70.0f, 6.625E+09f);
			ParticlesHeliumnPerCubePerCm.Add(80.0f, 1.626E+09f);
			ParticlesHeliumnPerCubePerCm.Add(90.0f, 3.918E+08f);
			ParticlesHeliumnPerCubePerCm.Add(100.0f, 1.087E+08f);
			ParticlesHeliumnPerCubePerCm.Add(110.0f, 4.820E+07f);
			ParticlesHeliumnPerCubePerCm.Add(120.0f, 3.060E+07f);
			ParticlesHeliumnPerCubePerCm.Add(130.0f, 3.344E+07f);
			ParticlesHeliumnPerCubePerCm.Add(140.0f, 3.566E+07f);
			ParticlesHeliumnPerCubePerCm.Add(150.0f, 3.257E+07f);
			ParticlesHeliumnPerCubePerCm.Add(160.0f, 2.933E+07f);
			ParticlesHeliumnPerCubePerCm.Add(170.0f, 2.675E+07f);
			ParticlesHeliumnPerCubePerCm.Add(180.0f, 2.467E+07f);
			ParticlesHeliumnPerCubePerCm.Add(190.0f, 2.296E+07f);
			ParticlesHeliumnPerCubePerCm.Add(200.0f, 2.150E+07f);
			ParticlesHeliumnPerCubePerCm.Add(210.0f, 2.021E+07f);
			ParticlesHeliumnPerCubePerCm.Add(220.0f, 1.909E+07f);
			ParticlesHeliumnPerCubePerCm.Add(230.0f, 1.809E+07f);
			ParticlesHeliumnPerCubePerCm.Add(240.0f, 1.717E+07f);
			ParticlesHeliumnPerCubePerCm.Add(250.0f, 1.633E+07f);
			ParticlesHeliumnPerCubePerCm.Add(260.0f, 1.555E+07f);
			ParticlesHeliumnPerCubePerCm.Add(270.0f, 1.483E+07f);
			ParticlesHeliumnPerCubePerCm.Add(280.0f, 1.415E+07f);
			ParticlesHeliumnPerCubePerCm.Add(290.0f, 1.352E+07f);
			ParticlesHeliumnPerCubePerCm.Add(300.0f, 1.292E+07f);
			ParticlesHeliumnPerCubePerCm.Add(400.0f, 8.365E+06f);
			ParticlesHeliumnPerCubePerCm.Add(500.0f, 5.518E+06f);
			ParticlesHeliumnPerCubePerCm.Add(600.0f, 3.687E+06f);
			ParticlesHeliumnPerCubePerCm.Add(700.0f, 2.491E+06f);
			ParticlesHeliumnPerCubePerCm.Add(800.0f, 1.702E+06f);
			ParticlesHeliumnPerCubePerCm.Add(900.0f, 1.175E+06f);
			ParticlesHeliumnPerCubePerCm.Add(1000.0f, 8.196E+05f);
			ParticlesHeliumnPerCubePerCm.Add(2000.0f, 4.098E+03f);
			ParticlesHeliumnPerCubePerCm.Add(4000.0f, 2.049E+01f);
			ParticlesHeliumnPerCubePerCm.Add(8000.0f, 1.0245E-01f);
			ParticlesHeliumnPerCubePerCm.Add(10000, 0f);
		}

		private void InitializeParticlesHydrogenCubeM()
		{
			if (ParticlesHydrogenCubePerMeter != null) return;

			ParticlesHydrogenCubePerMeter = new FloatCurve();

			ParticlesHydrogenCubePerMeter.Add(0, 0);
			ParticlesHydrogenCubePerMeter.Add(72.5f, 1.747e+9f);
			ParticlesHydrogenCubePerMeter.Add(73.0f, 2.872e+9f);
			ParticlesHydrogenCubePerMeter.Add(73.5f, 5.154e+9f);
			ParticlesHydrogenCubePerMeter.Add(74.0f, 1.009e+10f);
			ParticlesHydrogenCubePerMeter.Add(74.5f, 2.138e+10f);
			ParticlesHydrogenCubePerMeter.Add(75.0f, 4.836e+10f);
			ParticlesHydrogenCubePerMeter.Add(75.5f, 1.144e+11f);
			ParticlesHydrogenCubePerMeter.Add(76.0f, 2.760e+11f);
			ParticlesHydrogenCubePerMeter.Add(76.5f, 6.612e+11f);
			ParticlesHydrogenCubePerMeter.Add(77.0f, 1.531e+12f);
			ParticlesHydrogenCubePerMeter.Add(77.5f, 3.351e+12f);
			ParticlesHydrogenCubePerMeter.Add(78.0f, 6.813e+12f);
			ParticlesHydrogenCubePerMeter.Add(78.5f, 1.274e+13f);
			ParticlesHydrogenCubePerMeter.Add(79.0f, 2.180e+13f);
			ParticlesHydrogenCubePerMeter.Add(79.5f, 3.420e+13f);
			ParticlesHydrogenCubePerMeter.Add(80.0f, 4.945e+13f);
			ParticlesHydrogenCubePerMeter.Add(80.5f, 6.637e+13f);
			ParticlesHydrogenCubePerMeter.Add(81.0f, 8.346e+13f);
			ParticlesHydrogenCubePerMeter.Add(81.5f, 9.920e+13f);
			ParticlesHydrogenCubePerMeter.Add(82.0f, 1.124e+14f);
			ParticlesHydrogenCubePerMeter.Add(82.5f, 1.225e+14f);
			ParticlesHydrogenCubePerMeter.Add(83.0f, 1.292e+14f);
			ParticlesHydrogenCubePerMeter.Add(83.5f, 1.328e+14f);
			ParticlesHydrogenCubePerMeter.Add(84.0f, 1.335e+14f);
			ParticlesHydrogenCubePerMeter.Add(84.5f, 1.320e+14f);
			ParticlesHydrogenCubePerMeter.Add(85.0f, 1.287e+14f);
			ParticlesHydrogenCubePerMeter.Add(85.5f, 1.241e+14f);
			ParticlesHydrogenCubePerMeter.Add(86.0f, 1.187e+14f);
			ParticlesHydrogenCubePerMeter.Add(87, 1.066e+13f);
			ParticlesHydrogenCubePerMeter.Add(88, 9.426e+13f);
			ParticlesHydrogenCubePerMeter.Add(89, 8.257e+13f);
			ParticlesHydrogenCubePerMeter.Add(90, 7.203e+13f);
			ParticlesHydrogenCubePerMeter.Add(91, 6.276e+13f);
			ParticlesHydrogenCubePerMeter.Add(92, 5.474e+13f);
			ParticlesHydrogenCubePerMeter.Add(93, 4.786e+13f);
			ParticlesHydrogenCubePerMeter.Add(94, 4.198e+13f);
			ParticlesHydrogenCubePerMeter.Add(95, 3.698e+13f);
			ParticlesHydrogenCubePerMeter.Add(96, 3.272e+13f);
			ParticlesHydrogenCubePerMeter.Add(97, 2.909e+13f);
			ParticlesHydrogenCubePerMeter.Add(98, 2.598e+13f);
			ParticlesHydrogenCubePerMeter.Add(99, 2.332e+13f);
			ParticlesHydrogenCubePerMeter.Add(100, 2.101e+13f);
			ParticlesHydrogenCubePerMeter.Add(101, 1.901e+13f);
			ParticlesHydrogenCubePerMeter.Add(102, 1.726e+13f);
			ParticlesHydrogenCubePerMeter.Add(103, 1.572e+13f);
			ParticlesHydrogenCubePerMeter.Add(104, 1.435e+13f);
			ParticlesHydrogenCubePerMeter.Add(105, 1.313e+13f);
			ParticlesHydrogenCubePerMeter.Add(106, 1.203e+13f);
			ParticlesHydrogenCubePerMeter.Add(107, 1.104e+13f);
			ParticlesHydrogenCubePerMeter.Add(108, 1.013e+13f);
			ParticlesHydrogenCubePerMeter.Add(109, 9.299e+13f);
			ParticlesHydrogenCubePerMeter.Add(110, 8.534e+12f);
			ParticlesHydrogenCubePerMeter.Add(111, 7.827e+12f);
			ParticlesHydrogenCubePerMeter.Add(112, 7.173e+12f);
			ParticlesHydrogenCubePerMeter.Add(113, 6.569e+12f);
			ParticlesHydrogenCubePerMeter.Add(114, 6.012e+12f);
			ParticlesHydrogenCubePerMeter.Add(115, 5.500e+12f);
			ParticlesHydrogenCubePerMeter.Add(120, 3.551e+12f);
			ParticlesHydrogenCubePerMeter.Add(125, 2.477e+12f);
			ParticlesHydrogenCubePerMeter.Add(130, 1.805e+12f);
			ParticlesHydrogenCubePerMeter.Add(140, 1.029e+12f);
			ParticlesHydrogenCubePerMeter.Add(150, 6.468e+11f);
			ParticlesHydrogenCubePerMeter.Add(160, 4.485e+11f);
			ParticlesHydrogenCubePerMeter.Add(170, 3.400e+11f);
			ParticlesHydrogenCubePerMeter.Add(180, 2.774e+11f);
			ParticlesHydrogenCubePerMeter.Add(190, 2.394e+11f);
			ParticlesHydrogenCubePerMeter.Add(200, 2.154e+11f);
			ParticlesHydrogenCubePerMeter.Add(210, 1.995e+11f);
			ParticlesHydrogenCubePerMeter.Add(220, 1.887e+11f);
			ParticlesHydrogenCubePerMeter.Add(230, 1.809e+11f);
			ParticlesHydrogenCubePerMeter.Add(240, 1.752e+11f);
			ParticlesHydrogenCubePerMeter.Add(250, 1.707e+11f);
			ParticlesHydrogenCubePerMeter.Add(300, 1.569e+11f);
			ParticlesHydrogenCubePerMeter.Add(350, 1.477e+11f);
			ParticlesHydrogenCubePerMeter.Add(400, 1.399e+11f);
			ParticlesHydrogenCubePerMeter.Add(450, 1.327e+11f);
			ParticlesHydrogenCubePerMeter.Add(500, 1.260e+11f);
			ParticlesHydrogenCubePerMeter.Add(550, 1.198e+11f);
			ParticlesHydrogenCubePerMeter.Add(600, 1.139e+11f);
			ParticlesHydrogenCubePerMeter.Add(650, 1.085e+11f);
			ParticlesHydrogenCubePerMeter.Add(700, 1.033e+11f);
			ParticlesHydrogenCubePerMeter.Add(750, 9.848e+10f);
			ParticlesHydrogenCubePerMeter.Add(800, 9.393e+10f);
			ParticlesHydrogenCubePerMeter.Add(850, 8.965e+10f);
			ParticlesHydrogenCubePerMeter.Add(900, 8.562e+10f);
			ParticlesHydrogenCubePerMeter.Add(950, 8.182e+10f);
			ParticlesHydrogenCubePerMeter.Add(1000, 7.824e+10f);
			ParticlesHydrogenCubePerMeter.Add(2000, 3.912e+8f);
			ParticlesHydrogenCubePerMeter.Add(4000, 1.956e+6f);
			ParticlesHydrogenCubePerMeter.Add(8000, 9.780e+3f);
			ParticlesHydrogenCubePerMeter.Add(10000, 0);
		}

		private void InitializeParticlesAtmosphereCurbeM()
		{
			if (ParticlesAtmosphereCubePerMeter != null) return;

			ParticlesAtmosphereCubePerMeter = new FloatCurve();

			ParticlesAtmosphereCubePerMeter.Add(0, 2.55e+25f);
			ParticlesAtmosphereCubePerMeter.Add(2, 2.09e+25f);
			ParticlesAtmosphereCubePerMeter.Add(4, 1.70e+25f);
			ParticlesAtmosphereCubePerMeter.Add(6, 1.37e+25f);
			ParticlesAtmosphereCubePerMeter.Add(8, 1.09e+25f);
			ParticlesAtmosphereCubePerMeter.Add(10, 8.60e+24f);
			ParticlesAtmosphereCubePerMeter.Add(12, 6.49e+24f);
			ParticlesAtmosphereCubePerMeter.Add(14, 4.74e+24f);
			ParticlesAtmosphereCubePerMeter.Add(16, 3.46e+24f);
			ParticlesAtmosphereCubePerMeter.Add(18, 2.53e+24f);
			ParticlesAtmosphereCubePerMeter.Add(20, 1.85e+24f);
			ParticlesAtmosphereCubePerMeter.Add(22, 1.34e+24f);
			ParticlesAtmosphereCubePerMeter.Add(24, 9.76e+23f);
			ParticlesAtmosphereCubePerMeter.Add(26, 7.12e+23f);
			ParticlesAtmosphereCubePerMeter.Add(28, 5.21e+23f);
			ParticlesAtmosphereCubePerMeter.Add(30, 3.83e+23f);
			ParticlesAtmosphereCubePerMeter.Add(32, 2.81e+23f);
			ParticlesAtmosphereCubePerMeter.Add(34, 2.06e+23f);
			ParticlesAtmosphereCubePerMeter.Add(36, 1.51e+23f);
			ParticlesAtmosphereCubePerMeter.Add(38, 1.12e+23f);
			ParticlesAtmosphereCubePerMeter.Add(40, 8.31e+22f);
			ParticlesAtmosphereCubePerMeter.Add(42, 6.23e+22f);
			ParticlesAtmosphereCubePerMeter.Add(44, 4.70e+22f);
			ParticlesAtmosphereCubePerMeter.Add(46, 3.56e+22f);
			ParticlesAtmosphereCubePerMeter.Add(48, 2.74e+22f);
			ParticlesAtmosphereCubePerMeter.Add(50, 2.14e+22f);
			ParticlesAtmosphereCubePerMeter.Add(52, 1.68e+22f);
			ParticlesAtmosphereCubePerMeter.Add(54, 1.33e+22f);
			ParticlesAtmosphereCubePerMeter.Add(56, 1.05e+22f);
			ParticlesAtmosphereCubePerMeter.Add(58, 8.24e+21f);
			ParticlesAtmosphereCubePerMeter.Add(60, 6.44e+21f);
			ParticlesAtmosphereCubePerMeter.Add(65, 3.39e+21f);
			ParticlesAtmosphereCubePerMeter.Add(70, 1.72e+21f);
			ParticlesAtmosphereCubePerMeter.Add(75, 8.30e+20f);
			ParticlesAtmosphereCubePerMeter.Add(80, 3.84e+20f);
			ParticlesAtmosphereCubePerMeter.Add(85, 1.71e+20f);
			ParticlesAtmosphereCubePerMeter.Add(90, 7.12e+19f);
			ParticlesAtmosphereCubePerMeter.Add(95, 2.92e+19f);
			ParticlesAtmosphereCubePerMeter.Add(100, 1.19e+19f);
			ParticlesAtmosphereCubePerMeter.Add(110, 2.45e+18f);
			ParticlesAtmosphereCubePerMeter.Add(120, 5.11e+17f);
			ParticlesAtmosphereCubePerMeter.Add(140, 9.32e+16f);
			ParticlesAtmosphereCubePerMeter.Add(160, 3.16e+16f);
			ParticlesAtmosphereCubePerMeter.Add(180, 1.40e+16f);
			ParticlesAtmosphereCubePerMeter.Add(200, 7.18e+15f);
			ParticlesAtmosphereCubePerMeter.Add(300, 6.51e+14f);
			ParticlesAtmosphereCubePerMeter.Add(400, 9.13e+13f);
			ParticlesAtmosphereCubePerMeter.Add(500, 2.19e+13f);
			ParticlesAtmosphereCubePerMeter.Add(600, 4.89e+12f);
			ParticlesAtmosphereCubePerMeter.Add(700, 1.14e+12f);
			ParticlesAtmosphereCubePerMeter.Add(800, 5.86e+11f);
			ParticlesAtmosphereCubePerMeter.Add(100, 1.19e+19f);
			ParticlesAtmosphereCubePerMeter.Add(1000, 2.06e+11f);
			ParticlesAtmosphereCubePerMeter.Add(2000, 1.03e+9f);
			ParticlesAtmosphereCubePerMeter.Add(4000, 5.2e+6f);
			ParticlesAtmosphereCubePerMeter.Add(8000, 2.6e+4f);
			ParticlesAtmosphereCubePerMeter.Add(10000, 0);
		}

		private void InitializeDensityAtmosphereCubeCm()
		{
			if (MassDensityAtmosphereGramPerCubeCm != null) return;

			MassDensityAtmosphereGramPerCubeCm = new FloatCurve();

			MassDensityAtmosphereGramPerCubeCm.Add(000, 1.340E-03f);
			MassDensityAtmosphereGramPerCubeCm.Add(001, 1.195E-03f);
			MassDensityAtmosphereGramPerCubeCm.Add(002, 1.072E-03f);
			MassDensityAtmosphereGramPerCubeCm.Add(003, 9.649E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(004, 8.681E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(005, 7.790E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(006, 6.959E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(007, 6.179E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(008, 5.446E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(009, 4.762E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(010, 4.128E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(012, 3.035E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(014, 2.203E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(016, 1.605E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(018, 1.175E-04f);
			MassDensityAtmosphereGramPerCubeCm.Add(020, 8.573E-05f);
            MassDensityAtmosphereGramPerCubeCm.Add(025, 3.756E-05f);
			MassDensityAtmosphereGramPerCubeCm.Add(030, 1.611E-05f);
            MassDensityAtmosphereGramPerCubeCm.Add(035, 7.028E-06f);
			MassDensityAtmosphereGramPerCubeCm.Add(040, 3.262E-06f);
            MassDensityAtmosphereGramPerCubeCm.Add(045, 1.627E-06f);
			MassDensityAtmosphereGramPerCubeCm.Add(050, 8.602E-07f);
            MassDensityAtmosphereGramPerCubeCm.Add(055, 4.593E-07f);
            MassDensityAtmosphereGramPerCubeCm.Add(060, 1.214E-07f);
            MassDensityAtmosphereGramPerCubeCm.Add(065, 6.017E-08f);
			MassDensityAtmosphereGramPerCubeCm.Add(070, 6.017E-08f);
            MassDensityAtmosphereGramPerCubeCm.Add(075, 2.943E-08f);
			MassDensityAtmosphereGramPerCubeCm.Add(080, 1.439E-08f);
            MassDensityAtmosphereGramPerCubeCm.Add(085, 6.826E-09f);
			MassDensityAtmosphereGramPerCubeCm.Add(090, 3.080E-09f);
            MassDensityAtmosphereGramPerCubeCm.Add(095, 1.316E-09f);
			MassDensityAtmosphereGramPerCubeCm.Add(100, 5.357E-10f);
            MassDensityAtmosphereGramPerCubeCm.Add(105, 2.133E-10f);
			MassDensityAtmosphereGramPerCubeCm.Add(110, 8.711E-11f);
            MassDensityAtmosphereGramPerCubeCm.Add(115, 3.780E-11f);
			MassDensityAtmosphereGramPerCubeCm.Add(120, 1.844E-11f);
			MassDensityAtmosphereGramPerCubeCm.Add(130, 7.383E-12f);
			MassDensityAtmosphereGramPerCubeCm.Add(140, 3.781E-12f);
			MassDensityAtmosphereGramPerCubeCm.Add(150, 2.185E-12f);
			MassDensityAtmosphereGramPerCubeCm.Add(160, 1.364E-12f);
			MassDensityAtmosphereGramPerCubeCm.Add(170, 8.974E-13f);
			MassDensityAtmosphereGramPerCubeCm.Add(180, 6.145E-13f);
			MassDensityAtmosphereGramPerCubeCm.Add(190, 4.333E-13f);
			MassDensityAtmosphereGramPerCubeCm.Add(200, 3.127E-13f);
			MassDensityAtmosphereGramPerCubeCm.Add(210, 2.300E-13f);
			MassDensityAtmosphereGramPerCubeCm.Add(220, 1.718E-13f);
			MassDensityAtmosphereGramPerCubeCm.Add(230, 1.300E-13f);
			MassDensityAtmosphereGramPerCubeCm.Add(240, 9.954E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(250, 7.698E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(260, 6.007E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(270, 4.725E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(280, 3.744E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(290, 2.987E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(300, 2.397E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(310, 1.934E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(320, 1.569E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(330, 1.278E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(340, 1.046E-14f);
			MassDensityAtmosphereGramPerCubeCm.Add(350, 8.594E-15f);
			MassDensityAtmosphereGramPerCubeCm.Add(400, 3.377E-15f);
			MassDensityAtmosphereGramPerCubeCm.Add(450, 1.412E-15f);
			MassDensityAtmosphereGramPerCubeCm.Add(500, 6.205E-16f);
			MassDensityAtmosphereGramPerCubeCm.Add(550, 2.854E-16f);
			MassDensityAtmosphereGramPerCubeCm.Add(600, 1.385E-16f);
			MassDensityAtmosphereGramPerCubeCm.Add(650, 7.176E-17f);
			MassDensityAtmosphereGramPerCubeCm.Add(700, 4.031E-17f);
			MassDensityAtmosphereGramPerCubeCm.Add(750, 2.477E-17f);
			MassDensityAtmosphereGramPerCubeCm.Add(800, 1.660E-17f);
			MassDensityAtmosphereGramPerCubeCm.Add(850, 1.197E-17f);
			MassDensityAtmosphereGramPerCubeCm.Add(900, 9.114E-18f);
			MassDensityAtmosphereGramPerCubeCm.Add(950, 7.211E-18f);
			MassDensityAtmosphereGramPerCubeCm.Add(1000, 5.849E-18f);
			MassDensityAtmosphereGramPerCubeCm.Add(2000, 2.9245E-20f);
			MassDensityAtmosphereGramPerCubeCm.Add(4000, 1.46225E-22f);
			MassDensityAtmosphereGramPerCubeCm.Add(8000, 7.31125E-25f);
			MassDensityAtmosphereGramPerCubeCm.Add(10000, 0);
		}
	}
}