import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JToolBar;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import java.awt.Font;
import javax.swing.UIManager;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Color;

public class CalculadoraTOP {

	private JFrame frame;
	private JTextField textField;
	private JButton btnMc;
	private JButton btnMr;
	private JButton button_2;
	private JButton btnMs;
	private JButton button_4;
	private JButton button_5;
	private JButton button_6;
	private JButton button_7;
	private JButton button_8;
	private JButton button_9;
	private JButton button_10;
	private JButton button_11;
	private JButton button_12;
	private JButton button_13;
	private JButton btnx;
	private JButton button_15;
	private JButton button_16;
	private JButton button_17;
	private JButton button_18;
	private JButton button_19;
	private JButton btnMc_1;
	private JButton btnMr_1;
	private JButton btnMs_1;
	private JButton btnM;
	private JButton btnM_1;
	private JButton button_25;
	private JButton button_27;
	private JButton button_28;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					CalculadoraTOP window = new CalculadoraTOP();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public CalculadoraTOP() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.getContentPane().setBackground(new Color(230, 230, 250));
		frame.setBounds(100, 100, 263, 429);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		textField = new JTextField();
		textField.setFont(new Font("Lucida Grande", Font.PLAIN, 54));
		textField.setHorizontalAlignment(SwingConstants.RIGHT);
		textField.setText("0");
		textField.setBounds(7, 25, 244, 76);
		frame.getContentPane().add(textField);
		textField.setColumns(10);

		JLabel lblArchivo = new JLabel("Ver  Edicion  Ayuda");
		lblArchivo.setFont(new Font("Lucida Grande", Font.BOLD, 13));
		lblArchivo.setBackground(UIManager.getColor("Button.background"));
		lblArchivo.setBounds(6, 6, 216, 16);
		frame.getContentPane().add(lblArchivo);

		btnMc = new JButton("←");
		btnMc.setFont(new Font("Lucida Grande", Font.BOLD, 12));
		btnMc.setBackground(new Color(127, 255, 212));
		btnMc.setForeground(new Color(0, 0, 0));
		btnMc.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnMc.setBounds(14, 113, 46, 47);
		frame.getContentPane().add(btnMc);

		btnMr = new JButton("CE");
		btnMr.setBackground(new Color(127, 255, 212));
		btnMr.setForeground(UIManager.getColor("Button.light"));
		btnMr.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnMr.setBounds(60, 113, 46, 47);
		frame.getContentPane().add(btnMr);

		button_2 = new JButton("+/-");
		button_2.setBackground(new Color(127, 255, 212));
		button_2.setForeground(UIManager.getColor("Button.light"));
		button_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		button_2.setBounds(152, 113, 46, 47);
		frame.getContentPane().add(button_2);

		btnMs = new JButton("C");
		btnMs.setBackground(new Color(127, 255, 212));
		btnMs.setForeground(UIManager.getColor("Button.light"));
		btnMs.setBounds(106, 113, 46, 47);
		frame.getContentPane().add(btnMs);

		button_4 = new JButton("√");
		button_4.setBackground(new Color(127, 255, 212));
		button_4.setForeground(UIManager.getColor("Button.light"));
		button_4.setBounds(198, 113, 46, 47);
		frame.getContentPane().add(button_4);

		button_5 = new JButton("1");
		button_5.setBackground(new Color(127, 255, 212));
		button_5.setForeground(UIManager.getColor("Button.light"));
		button_5.setBounds(14, 304, 46, 47);
		frame.getContentPane().add(button_5);

		button_6 = new JButton("2");
		button_6.setBackground(new Color(127, 255, 212));
		button_6.setForeground(UIManager.getColor("Button.light"));
		button_6.setBounds(60, 304, 46, 47);
		frame.getContentPane().add(button_6);

		button_7 = new JButton("3");
		button_7.setBackground(new Color(127, 255, 212));
		button_7.setForeground(UIManager.getColor("Button.light"));
		button_7.setBounds(106, 304, 46, 47);
		frame.getContentPane().add(button_7);

		button_8 = new JButton("-");
		button_8.setBackground(new Color(127, 255, 212));
		button_8.setForeground(UIManager.getColor("Button.light"));
		button_8.setBounds(152, 304, 46, 47);
		frame.getContentPane().add(button_8);

		button_9 = new JButton("=");
		button_9.setFont(new Font("Lucida Grande", Font.BOLD, 13));
		button_9.setBackground(new Color(127, 255, 212));
		button_9.setForeground(UIManager.getColor("Button.light"));
		button_9.setBounds(198, 304, 46, 94);
		frame.getContentPane().add(button_9);

		button_10 = new JButton("4");
		button_10.setBackground(new Color(127, 255, 212));
		button_10.setForeground(UIManager.getColor("Button.light"));
		button_10.setBounds(14, 256, 46, 47);
		frame.getContentPane().add(button_10);

		button_11 = new JButton("5");
		button_11.setBackground(new Color(127, 255, 212));
		button_11.setForeground(UIManager.getColor("Button.light"));
		button_11.setBounds(60, 256, 46, 47);
		frame.getContentPane().add(button_11);

		button_12 = new JButton("6");
		button_12.setBackground(new Color(127, 255, 212));
		button_12.setForeground(UIManager.getColor("Button.light"));
		button_12.setBounds(106, 256, 46, 47);
		frame.getContentPane().add(button_12);

		button_13 = new JButton("*");
		button_13.setBackground(new Color(127, 255, 212));
		button_13.setForeground(UIManager.getColor("Button.light"));
		button_13.setBounds(152, 256, 46, 47);
		frame.getContentPane().add(button_13);

		btnx = new JButton("1/x");
		btnx.setBackground(new Color(127, 255, 212));
		btnx.setForeground(UIManager.getColor("Button.light"));
		btnx.setBounds(198, 256, 46, 47);
		frame.getContentPane().add(btnx);

		button_15 = new JButton("7");
		button_15.setBackground(new Color(127, 255, 212));
		button_15.setForeground(UIManager.getColor("Button.light"));
		button_15.setBounds(14, 208, 46, 47);
		frame.getContentPane().add(button_15);

		button_16 = new JButton("8");
		button_16.setBackground(new Color(127, 255, 212));
		button_16.setForeground(UIManager.getColor("Button.light"));
		button_16.setBounds(60, 208, 46, 47);
		frame.getContentPane().add(button_16);

		button_17 = new JButton("9");
		button_17.setBackground(new Color(127, 255, 212));
		button_17.setForeground(UIManager.getColor("Button.light"));
		button_17.setBounds(106, 208, 46, 47);
		frame.getContentPane().add(button_17);

		button_18 = new JButton("/");
		button_18.setBackground(new Color(127, 255, 212));
		button_18.setForeground(UIManager.getColor("Button.light"));
		button_18.setBounds(152, 208, 46, 47);
		frame.getContentPane().add(button_18);

		button_19 = new JButton("%");
		button_19.setBackground(new Color(127, 255, 212));
		button_19.setForeground(UIManager.getColor("Button.light"));
		button_19.setBounds(198, 208, 46, 47);
		frame.getContentPane().add(button_19);

		btnMc_1 = new JButton("MC");
		btnMc_1.setBackground(new Color(127, 255, 212));
		btnMc_1.setForeground(UIManager.getColor("Button.light"));
		btnMc_1.setBounds(14, 160, 46, 47);
		frame.getContentPane().add(btnMc_1);

		btnMr_1 = new JButton("MR");
		btnMr_1.setBackground(new Color(127, 255, 212));
		btnMr_1.setForeground(UIManager.getColor("Button.light"));
		btnMr_1.setBounds(60, 160, 46, 47);
		frame.getContentPane().add(btnMr_1);

		btnMs_1 = new JButton("MS");
		btnMs_1.setBackground(new Color(127, 255, 212));
		btnMs_1.setForeground(UIManager.getColor("Button.light"));
		btnMs_1.setBounds(106, 160, 46, 47);
		frame.getContentPane().add(btnMs_1);

		btnM = new JButton("M+");
		btnM.setBackground(new Color(127, 255, 212));
		btnM.setForeground(UIManager.getColor("Button.light"));
		btnM.setBounds(152, 160, 46, 47);
		frame.getContentPane().add(btnM);

		btnM_1 = new JButton("M-");
		btnM_1.setBackground(new Color(127, 255, 212));
		btnM_1.setForeground(UIManager.getColor("Button.light"));
		btnM_1.setBounds(198, 160, 46, 47);
		frame.getContentPane().add(btnM_1);

		button_25 = new JButton("0");
		button_25.setBackground(new Color(127, 255, 212));
		button_25.setForeground(UIManager.getColor("Button.light"));
		button_25.setBounds(14, 351, 92, 47);
		frame.getContentPane().add(button_25);

		button_27 = new JButton(".");
		button_27.setBackground(new Color(127, 255, 212));
		button_27.setForeground(UIManager.getColor("Button.light"));
		button_27.setBounds(106, 351, 46, 47);
		frame.getContentPane().add(button_27);

		button_28 = new JButton("+");
		button_28.setBackground(new Color(127, 255, 212));
		button_28.setForeground(UIManager.getColor("Button.light"));
		button_28.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		button_28.setBounds(152, 351, 46, 47);
		frame.getContentPane().add(button_28);
	}
}