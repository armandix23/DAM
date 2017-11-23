import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextArea;
import javax.swing.border.LineBorder;
import java.awt.Color;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class EjercicioPAG21 {

	private JFrame frmListaDeLa;
	private JTextField txtCliente;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;
	private double totalCompra;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					EjercicioPAG21 window = new EjercicioPAG21();
					window.frmListaDeLa.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public EjercicioPAG21() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmListaDeLa = new JFrame();
		
		frmListaDeLa.setResizable(false);
		frmListaDeLa.setTitle("Lista de la compra");
		frmListaDeLa.setBounds(100, 100, 450, 253);
		frmListaDeLa.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmListaDeLa.getContentPane().setLayout(null);

		JLabel lblIdentificacinDelUsuario = new JLabel("Identificaci\u00F3n del usuario");
		lblIdentificacinDelUsuario.setBounds(10, 11, 128, 27);
		frmListaDeLa.getContentPane().add(lblIdentificacinDelUsuario);

		txtCliente = new JTextField();
		txtCliente.setEditable(false);
		txtCliente.setText("Cliente");
		txtCliente.setBounds(137, 14, 94, 20);
		frmListaDeLa.getContentPane().add(txtCliente);
		txtCliente.setColumns(10);

		JLabel lblTotalAPagar = new JLabel("Total a pagar (\u20AC)");
		lblTotalAPagar.setBounds(242, 11, 94, 27);
		frmListaDeLa.getContentPane().add(lblTotalAPagar);

		textField_1 = new JTextField();
		textField_1.setEditable(false);
		textField_1.setText("0,0");
		textField_1.setColumns(10);
		textField_1.setBounds(340, 14, 94, 20);
		frmListaDeLa.getContentPane().add(textField_1);

		JLabel lblProducto = new JLabel("Producto");
		lblProducto.setBounds(10, 49, 64, 27);
		frmListaDeLa.getContentPane().add(lblProducto);

		textField_2 = new JTextField();
		
		textField_2.setColumns(10);
		textField_2.setBounds(65, 49, 86, 20);
		frmListaDeLa.getContentPane().add(textField_2);

		JLabel lblCantidadYPreciounidad = new JLabel("Cantidad y precio/unidad");
		lblCantidadYPreciounidad.setBounds(161, 49, 128, 27);
		frmListaDeLa.getContentPane().add(lblCantidadYPreciounidad);

		JComboBox comboBox = new JComboBox();
		
		comboBox.setModel(new DefaultComboBoxModel(new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }));
		comboBox.setBounds(287, 52, 43, 20);
		frmListaDeLa.getContentPane().add(comboBox);

		textField_3 = new JTextField();
		textField_3.setColumns(10);
		textField_3.setBounds(340, 52, 94, 20);
		frmListaDeLa.getContentPane().add(textField_3);

		JButton btnNewButton = new JButton("A\u00F1adir producto creado");
		
		
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
			}
		});

		JButton btnFinalizarCompra = new JButton("Finalizar compra");
		
		

		btnNewButton.setBounds(273, 118, 151, 23);
		frmListaDeLa.getContentPane().add(btnNewButton);

		btnFinalizarCompra.setBounds(273, 171, 151, 23);
		frmListaDeLa.getContentPane().add(btnFinalizarCompra);

		JTextArea textArea = new JTextArea();
		textArea.setBorder(new LineBorder(new Color(0, 0, 0)));
		textArea.setEditable(false);
		textArea.setBounds(10, 85, 255, 122);
		frmListaDeLa.getContentPane().add(textArea);

		// EVENTOS // Poner siempre abajo
		
		// Evento JFrame
				frmListaDeLa.addWindowListener(new WindowAdapter() { // Cuando se habra la interfaz en el jcombo aparezca 0
					@Override
					public void windowOpened(WindowEvent arg0) {
						comboBox.setSelectedItem(null);
					}
				});
		
				
			//EVENTO AÑADIR PRODUCTO
				btnNewButton.addMouseListener(new MouseAdapter() {
					@Override
					public void mouseClicked(MouseEvent arg0) {
						String producto = textField_2.getText().toString(); // "Patatas"
						String cantidad = comboBox.getSelectedItem().toString(); // "2"
						String precio = textField_3.getText().toString(); // "0.5"
						
						
						
						double cantidadD = Double.parseDouble(cantidad); // Para pasarlo a numerico, double // 2
						double precioD = Double.parseDouble(precio); // 0.5
						double calculo = cantidadD * precioD;
						
						totalCompra = totalCompra + calculo;
						textField_1.setText(String.valueOf(totalCompra));
						
						textArea.setText(textArea.getText()+producto + " ("+cantidad+")  "+" -->"+ calculo+"\n");
						
						textField_2.setText(" ");
						textField_3.setText(" ");
						comboBox.setSelectedItem(null);
								
					}
				});
				
				// FINALIZAR EL PROGRAMA CON ALERT
				btnFinalizarCompra.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent arg0) {
						JOptionPane.showMessageDialog(null,"ADIOS SUB, pagalo ya "+totalCompra,"Gracias por su compra", JOptionPane.INFORMATION_MESSAGE);
					}
				});
				
				
				
				
		
				
							
		
	/*	// Evento Button
		btnFinalizarCompra.addActionListener(new ActionListener() { // Cuando demos click en finalizar compra poner verde el textarea
			public void actionPerformed(ActionEvent arg0) {
				Color verde = new Color(0, 255, 0);
				textArea.setBackground(verde);
			}
		});
		
		
		
		// EvenTo JTextField
		textField_2.addKeyListener(new KeyAdapter() {
			@Override
			public void keyTyped(KeyEvent arg0) {
				if(textField_2.getText().length()>=6) {
					System.out.println("Mayor que 6"); //alert
				}
			}
		});
		
		// Evento ComboBox
		comboBox.addItemListener(new ItemListener() { // Evento del combo
			public void itemStateChanged(ItemEvent argc0) {
				if (comboBox.getSelectedItem()!=null) {
				String seleccionado= comboBox.getSelectedItem().toString();
				textField_3.setText(seleccionado);
			}
		}
		}); */
  }
}

