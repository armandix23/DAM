import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import javax.swing.JRadioButton;
import javax.swing.JLabel;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import com.toedter.calendar.JDayChooser;
import com.toedter.calendar.JDateChooser;
import javax.swing.JTextPane;
import java.awt.Font;
import java.awt.Color;
import javax.swing.JTextField;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JPasswordField;
import javax.swing.JList;
import javax.swing.AbstractListModel;
import javax.swing.JScrollBar;
import javax.swing.JScrollPane;

public class EjercicioPAG18 {

	private JFrame frmEligeVacaciones;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	private JTextField textField;
	private JPasswordField passwordField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					EjercicioPAG18 window = new EjercicioPAG18();
					window.frmEligeVacaciones.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public EjercicioPAG18() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmEligeVacaciones = new JFrame();
		frmEligeVacaciones.setResizable(false);
		frmEligeVacaciones.setTitle("Elige vacaciones");
		frmEligeVacaciones.getContentPane().setBackground(Color.PINK);
		frmEligeVacaciones.setBounds(100, 100, 499, 374);
		frmEligeVacaciones.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmEligeVacaciones.getContentPane().setLayout(null);
		
		JMenuBar menuBar = new JMenuBar();
		menuBar.setBounds(0, 11, 54, 21);
		frmEligeVacaciones.getContentPane().add(menuBar);
		
		JMenu mnEdicion = new JMenu("Edicion");
		menuBar.add(mnEdicion);
		
		JMenuItem mntmCopiar = new JMenuItem("Copiar");
		mnEdicion.add(mntmCopiar);
		
		JMenuItem mntmPegar = new JMenuItem("Pegar");
		mnEdicion.add(mntmPegar);
		
		JMenuItem mntmEliminar = new JMenuItem("Eliminar");
		mnEdicion.add(mntmEliminar);
		
		JRadioButton rdbtnMadrid = new JRadioButton("Madrid");
		rdbtnMadrid.setSelected(true);
		buttonGroup.add(rdbtnMadrid);
		rdbtnMadrid.setBounds(56, 157, 109, 23);
		frmEligeVacaciones.getContentPane().add(rdbtnMadrid);
		
		JRadioButton rdbtnBarcelona = new JRadioButton("Barcelona");
		buttonGroup.add(rdbtnBarcelona);
		rdbtnBarcelona.setBounds(56, 183, 109, 23);
		frmEligeVacaciones.getContentPane().add(rdbtnBarcelona);
		
		JRadioButton rdbtnSevilla = new JRadioButton("Sevilla");
		buttonGroup.add(rdbtnSevilla);
		rdbtnSevilla.setBounds(56, 209, 109, 23);
		frmEligeVacaciones.getContentPane().add(rdbtnSevilla);
		
		JLabel lblEligeUnaCiudad = new JLabel("Elige una ciudad de destino");
		lblEligeUnaCiudad.setBounds(56, 122, 180, 28);
		frmEligeVacaciones.getContentPane().add(lblEligeUnaCiudad);
		
		JButton btnAceptar = new JButton("ACEPTAR");
		btnAceptar.setBounds(56, 273, 89, 23);
		frmEligeVacaciones.getContentPane().add(btnAceptar);
		
		JButton btnCancelar = new JButton("CANCELAR");
		btnCancelar.setBounds(316, 273, 110, 23);
		frmEligeVacaciones.getContentPane().add(btnCancelar);
		
		JDateChooser dateChooser = new JDateChooser();
		dateChooser.setBounds(316, 242, 110, 20);
		frmEligeVacaciones.getContentPane().add(dateChooser);
		
		JLabel lblEligeFecha = new JLabel("Elige fecha");
		lblEligeFecha.setBounds(240, 244, 72, 14);
		frmEligeVacaciones.getContentPane().add(lblEligeFecha);
		
		JLabel lblVacaciones = new JLabel("VACACIONES");
		lblVacaciones.setFont(new Font("Tahoma", Font.PLAIN, 57));
		lblVacaciones.setBounds(66, 23, 348, 50);
		frmEligeVacaciones.getContentPane().add(lblVacaciones);
		
		JComboBox comboBox = new JComboBox();
		comboBox.setModel(new DefaultComboBoxModel(new String[] {"1", "2", "3", "4", "5", "Mas"}));
		comboBox.setBounds(321, 210, 38, 20);
		frmEligeVacaciones.getContentPane().add(comboBox);
		
		JLabel lblUsuario = new JLabel("Usuario");
		lblUsuario.setBounds(26, 96, 78, 15);
		frmEligeVacaciones.getContentPane().add(lblUsuario);
		
		JLabel lblPassword = new JLabel("Password");
		lblPassword.setBounds(240, 96, 72, 15);
		frmEligeVacaciones.getContentPane().add(lblPassword);
		
		textField = new JTextField();
		textField.setBounds(79, 93, 86, 20);
		frmEligeVacaciones.getContentPane().add(textField);
		textField.setColumns(10);
		
		JLabel lblEquipaje = new JLabel("Equipaje");
		lblEquipaje.setBounds(240, 213, 78, 15);
		frmEligeVacaciones.getContentPane().add(lblEquipaje);
		
		passwordField = new JPasswordField();
		passwordField.setBounds(316, 93, 89, 20);
		frmEligeVacaciones.getContentPane().add(passwordField);
		
		JList list = new JList();
		list.setBounds(316, 141, 1, 1);
		frmEligeVacaciones.getContentPane().add(list);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(316, 127, 103, 52);
		frmEligeVacaciones.getContentPane().add(scrollPane);
		
		JList list_1 = new JList();
		scrollPane.setViewportView(list_1);
		list_1.setModel(new AbstractListModel() {
			String[] values = new String[] {"Pasajero", "VIP", "VIP PLUS", "RATA", "TRASTERO", "ALA", "CLIENT VIP MOST"};
			public int getSize() {
				return values.length;
			}
			public Object getElementAt(int index) {
				return values[index];
			}
		});
		
		JLabel lblTipo = new JLabel("Tipo");
		lblTipo.setBounds(240, 129, 72, 15);
		frmEligeVacaciones.getContentPane().add(lblTipo);
	}
}
