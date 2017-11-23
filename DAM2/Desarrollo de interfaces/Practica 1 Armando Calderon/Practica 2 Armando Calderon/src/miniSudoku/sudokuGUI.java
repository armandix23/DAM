package miniSudoku;

import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JTextField;
import javax.swing.SwingConstants;
import java.awt.Color;

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.SystemColor;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.border.LineBorder;
import java.awt.Cursor;

public class sudokuGUI {

	private JFrame frame;
	private JFrame frmMinisudoku;
	private JTextField casilla;
	private JTextField casilla_1;
	private JTextField casilla_2;
	private JTextField casilla_3;
	private JTextField casilla_4;
	private JTextField casilla_5;
	private JTextField casilla_6;
	private JTextField casilla_7;
	private JTextField casilla_8;
	private JTextField casilla_9;
	private JTextField casilla_10;
	private JTextField casilla_11;
	private JTextField casilla_12;
	private JTextField casilla_13;
	private JTextField casilla_14;
	private JTextField casilla_15;
	private JRadioButton Redimensionar;
	private JRadioButton NoRedimensionar;
	private final ButtonGroup buttonGroup = new ButtonGroup();

	// dimension of input
	static int N = 4;

	public static int getN() {
		return N;
	}

	public static void setN(int n) {
		N = n;
	}

	// sample input
	static int grid[][] = { { 2, 0, 0, 0 }, //
			{ 0, 3, 0, 4 }, //
			{ 3, 0, 0, 1 }, //
			{ 4, 0, 3, 0 } };

	static int gridSolution[][] = { { 2, 4, 1, 3 }, //
			{ 1, 3, 2, 4 }, //
			{ 3, 2, 4, 1 }, //
			{ 4, 1, 3, 2 } };

	public static int[][] getGrid() {
		return grid;
	}

	public static void setGrid(int[][] grid) {
		Sudoku.grid = grid;
	}

	/**
	 * Utility function to check whether @param value is valid for @param cell
	 */

	static boolean isValid(Cell cell, int value) {

		if (grid[cell.row][cell.col] != 0) {
			throw new RuntimeException("Cannot call for cell which already has a value");
		}

		// if v present row, return false
		for (int c = 0; c < 4; c++) {
			if (grid[cell.row][c] == value)
				return false;
		}

		// if v present in col, return false
		for (int r = 0; r < 4; r++) {
			if (grid[r][cell.col] == value)
				return false;
		}

		// if v present in grid, return false

		// to get the grid we should calculate (x1,y1) (x2,y2)
		int x1 = 2 * (cell.row / 2);
		int y1 = 2 * (cell.col / 2);
		int x2 = x1 + 1;
		int y2 = y1 + 1;

		for (int x = x1; x <= x2; x++)
			for (int y = y1; y <= y2; y++)
				if (grid[x][y] == value)
					return false;

		// if value not present in row, col and bounding box, return true
		return true;
	}

	// simple function to get the next cell
	// read for yourself, very simple and straight forward
	static Cell getNextCell(Cell cur) {

		int row = cur.row;
		int col = cur.col;

		// next cell => col++
		col++;

		// if col > 8, then col = 0, row++
		// reached end of row, got to next row
		if (col > 3) {
			// goto next line
			col = 0;
			row++;
		}

		// reached end of matrix, return null
		if (row > 3)
			return null; // reached end

		Cell next = new Cell(row, col);
		return next;
	}

	// everything is put together here
	// very simple solution
	// must return true, if the soduku is solved, return false otherwise
	public boolean solve(Cell cur) {

		// if the cell is null, we have reached the end
		if (cur == null)
			return true;

		// if grid[cur] already has a value, there is nothing to solve here,
		// continue on to next cell
		if (grid[cur.row][cur.col] != 0) {
			// return whatever is being returned by solve(next)
			// i.e the state of soduku's solution is not being determined by
			// this cell, but by other cells
			return solve(getNextCell(cur));
		}

		// this is where each possible value is being assigned to the cell, and
		// checked if a gridSolution could be arrived at.

		// if grid[cur] doesn't have a value
		// try each possible value
		for (int i = 1; i <= 4; i++) {
			// check if valid, if valid, then update
			boolean valid = isValid(cur, i);

			if (!valid) // i not valid for this cell, try other values
				continue;

			// assign here
			grid[cur.row][cur.col] = i;

			// continue with next cell
			boolean solved = solve(getNextCell(cur));
			// if solved, return, else try other values
			if (solved)
				return true;
			else
				grid[cur.row][cur.col] = 0; // reset
			// continue with other possible values
		}

		// if you reach here, then no value from 1 - 9 for this cell can solve
		// return false
		return false;
	}

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					sudokuGUI window = new sudokuGUI();
					window.frmMinisudoku.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public sudokuGUI() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		frmMinisudoku = new JFrame();
		frmMinisudoku.setResizable(false);
		frmMinisudoku.setCursor(Cursor.getPredefinedCursor(Cursor.CROSSHAIR_CURSOR));
		frmMinisudoku.setTitle("MiniSudoku");
		frmMinisudoku.setForeground(new Color(128, 0, 0));
		frmMinisudoku.setBackground(new Color(186, 85, 211));
		frmMinisudoku.setBounds(100, 100, 450, 300);
		frmMinisudoku.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmMinisudoku.getContentPane().setLayout(new BorderLayout(0, 0));

		JOptionPane.showMessageDialog(null, "Bievenido al sudoku", "Mensaje del sistema",
				JOptionPane.INFORMATION_MESSAGE);

		JPanel panel_1 = new JPanel();
		frmMinisudoku.getContentPane().add(panel_1, BorderLayout.SOUTH);

		JButton Resolver = new JButton("RESOLVER AUTOMATICAMENTE");
		Resolver.setBackground(new Color(152, 251, 152));

		panel_1.add(Resolver);

		JButton Comprobar = new JButton("COMPROBAR MANUAL");
		Comprobar.setBackground(new Color(152, 251, 152));

		panel_1.add(Comprobar);

		JPanel panel_3 = new JPanel();
		frmMinisudoku.getContentPane().add(panel_3, BorderLayout.EAST);
		panel_3.setLayout(new GridLayout(5, 0, 0, 0));

		JButton Reiniciar = new JButton("REINICIAR");
		Reiniciar.setBorder(new LineBorder(new Color(0, 0, 0)));
		Reiniciar.setBackground(new Color(255, 235, 205));

		panel_3.add(Reiniciar);

		JButton Salir = new JButton("SALIR ");
		Salir.setBorder(new LineBorder(new Color(0, 0, 0)));
		Salir.setBackground(new Color(255, 235, 205));

		panel_3.add(Salir);

		JCheckBox Sombrear = new JCheckBox("SOMBREADO");
		Sombrear.setBorder(new LineBorder(new Color(0, 0, 0)));
		Sombrear.setBackground(SystemColor.inactiveCaption);

		Sombrear.setSelected(true);
		panel_3.add(Sombrear);

		Redimensionar = new JRadioButton("REDIMENSIONAR");
		Redimensionar.setBorder(new LineBorder(new Color(0, 0, 0)));
		Redimensionar.setBackground(SystemColor.inactiveCaption);
		buttonGroup.add(Redimensionar);
		panel_3.add(Redimensionar);

		NoRedimensionar = new JRadioButton("NO REDIMENSIONAR");
		NoRedimensionar.setSelected(true);
		NoRedimensionar.setBorder(new LineBorder(new Color(0, 0, 0)));
		NoRedimensionar.setBackground(SystemColor.inactiveCaption);

		buttonGroup.add(NoRedimensionar);
		panel_3.add(NoRedimensionar);

		JPanel panel_4 = new JPanel();
		frmMinisudoku.getContentPane().add(panel_4, BorderLayout.CENTER);
		panel_4.setLayout(new GridLayout(4, 4, 0, 0));

		casilla = new JTextField();
		casilla.setEditable(false);
		casilla.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla.setHorizontalAlignment(SwingConstants.CENTER);
		casilla.setText("2");
		panel_4.add(casilla);
		casilla.setColumns(10);

		casilla_1 = new JTextField();
		casilla_1.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_1.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_1);
		casilla_1.setColumns(10);

		casilla_2 = new JTextField();
		casilla_2.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_2.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_2);
		casilla_2.setColumns(10);

		casilla_3 = new JTextField();
		casilla_3.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_3.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_3);
		casilla_3.setColumns(10);

		casilla_4 = new JTextField();
		casilla_4.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_4.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_4);
		casilla_4.setColumns(10);

		casilla_5 = new JTextField();
		casilla_5.setEditable(false);
		casilla_5.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_5.setHorizontalAlignment(SwingConstants.CENTER);
		casilla_5.setText("3");
		panel_4.add(casilla_5);
		casilla_5.setColumns(10);

		casilla_6 = new JTextField();
		casilla_6.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_6.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_6);
		casilla_6.setColumns(10);

		casilla_7 = new JTextField();
		casilla_7.setEditable(false);
		casilla_7.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_7.setHorizontalAlignment(SwingConstants.CENTER);
		casilla_7.setText("4");
		panel_4.add(casilla_7);
		casilla_7.setColumns(10);

		casilla_8 = new JTextField();
		casilla_8.setEditable(false);
		casilla_8.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_8.setHorizontalAlignment(SwingConstants.CENTER);
		casilla_8.setText("3");
		panel_4.add(casilla_8);
		casilla_8.setColumns(10);

		casilla_9 = new JTextField();
		casilla_9.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_9.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_9);
		casilla_9.setColumns(10);

		casilla_10 = new JTextField();
		casilla_10.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_10.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_10);
		casilla_10.setColumns(10);

		casilla_11 = new JTextField();
		casilla_11.setEditable(false);
		casilla_11.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_11.setHorizontalAlignment(SwingConstants.CENTER);
		casilla_11.setText("1");
		panel_4.add(casilla_11);
		casilla_11.setColumns(10);

		casilla_12 = new JTextField();
		casilla_12.setEditable(false);
		casilla_12.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_12.setHorizontalAlignment(SwingConstants.CENTER);
		casilla_12.setText("4");
		panel_4.add(casilla_12);
		casilla_12.setColumns(10);

		casilla_13 = new JTextField();
		casilla_13.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_13.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_13);
		casilla_13.setColumns(10);

		casilla_14 = new JTextField();
		casilla_14.setEditable(false);
		casilla_14.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_14.setHorizontalAlignment(SwingConstants.CENTER);
		casilla_14.setText("3");
		panel_4.add(casilla_14);
		casilla_14.setColumns(10);

		casilla_15 = new JTextField();
		casilla_15.setFont(new Font("Stencil", Font.PLAIN, 30));
		casilla_15.setHorizontalAlignment(SwingConstants.CENTER);
		panel_4.add(casilla_15);
		casilla_15.setColumns(10);

		// REDIM
		Redimensionar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				NoRedimensionar.setSelected(false);
				frmMinisudoku.setResizable(true);
			}
		});

		// NO REDIM
		NoRedimensionar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Redimensionar.setSelected(false);
				frmMinisudoku.setResizable(false);
			}
		});

		// BOTON REINICIAR
		Reiniciar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				casilla_1.setText("");
				casilla_2.setText("");
				casilla_3.setText("");
				casilla_4.setText("");
				casilla_6.setText("");
				casilla_9.setText("");
				casilla_10.setText("");
				casilla_13.setText("");
				casilla_15.setText("");

				casilla.setEditable(false);
				casilla_1.setEditable(true);
				casilla_2.setEditable(true);
				casilla_3.setEditable(true);
				casilla_4.setEditable(true);
				casilla_5.setEditable(false);
				casilla_6.setEditable(true);
				casilla_7.setEditable(false);
				casilla_8.setEditable(false);
				casilla_9.setEditable(true);
				casilla_10.setEditable(true);
				casilla_11.setEditable(false);
				casilla_12.setEditable(false);
				casilla_13.setEditable(true);
				casilla_14.setEditable(false);
				casilla_15.setEditable(true);
			}
		});

		// COMPROBAR MANUAL
		Comprobar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				int text1 = gridSolution[0][1];
				int text2 = gridSolution[0][2];
				int text3 = gridSolution[0][3];
				int text4 = gridSolution[1][0];
				int text5 = gridSolution[1][2];
				int text6 = gridSolution[2][1];
				int text7 = gridSolution[2][2];
				int text8 = gridSolution[3][1];
				int text9 = gridSolution[3][3];

				if (casilla_1.getText().equals(String.valueOf(text1))
						&& casilla_2.getText().equals(String.valueOf(text2))
						&& casilla_3.getText().equals(String.valueOf(text3))
						&& casilla_4.getText().equals(String.valueOf(text4))
						&& casilla_6.getText().equals(String.valueOf(text5))
						&& casilla_9.getText().equals(String.valueOf(text6))
						&& casilla_10.getText().equals(String.valueOf(text7))
						&& casilla_13.getText().equals(String.valueOf(text8))
						&& casilla_15.getText().equals(String.valueOf(text9))) {

					JOptionPane.showMessageDialog(null, "Has completado correctamente el sudoku", "Mensaje del sistema",
							JOptionPane.INFORMATION_MESSAGE);
				} else {
					JOptionPane.showMessageDialog(null, "Le falta un numero o tiene un error", "Error",
							JOptionPane.ERROR_MESSAGE);
				}
			}
		});

		// SALIR
		Salir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				int Salir = JOptionPane.showConfirmDialog(null, "¿Quiere salir del SUDOKU?", "Mensaje del sistema",
						JOptionPane.YES_NO_OPTION);
				if (Salir != 1) {
					System.exit(0);
				}

			}
		});

		// RESOLVER
		Resolver.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Sudoku prueba = new Sudoku();

				boolean solved = prueba.solve(new Cell(0, 0));
				if (!solved) {
					System.out.println("SUDOKU cannot be solved.");
					return;
				}

				Principal.printGrid(Sudoku.getGrid());

				int text1 = gridSolution[0][1];
				int text2 = gridSolution[0][2];
				int text3 = gridSolution[0][3];
				int text4 = gridSolution[1][0];
				int text5 = gridSolution[1][2];
				int text6 = gridSolution[2][1];
				int text7 = gridSolution[2][2];
				int text8 = gridSolution[3][1];
				int text9 = gridSolution[3][3];

				casilla_1.setText(String.valueOf(text1));
				casilla_2.setText(String.valueOf(text2));
				casilla_3.setText(String.valueOf(text3));
				casilla_4.setText(String.valueOf(text4));
				casilla_6.setText(String.valueOf(text5));
				casilla_9.setText(String.valueOf(text6));
				casilla_10.setText(String.valueOf(text7));
				casilla_13.setText(String.valueOf(text8));
				casilla_15.setText(String.valueOf(text9));

				casilla_1.setEditable(false);
				casilla_2.setEditable(false);
				casilla_3.setEditable(false);
				casilla_4.setEditable(false);
				casilla_5.setEditable(false);
				casilla_6.setEditable(false);
				casilla_7.setEditable(false);
				casilla_8.setEditable(false);
				casilla_9.setEditable(false);
				casilla_10.setEditable(false);
				casilla_11.setEditable(false);
				casilla_12.setEditable(false);
				casilla_13.setEditable(false);
				casilla_14.setEditable(false);
				casilla_15.setEditable(false);
			}
		});

		// SOMBREAR
		Sombrear.addMouseListener(new MouseAdapter() {

			public void mouseClicked(MouseEvent arg0) {
				if (Sombrear.isSelected()) {
					casilla.setBackground(SystemColor.lightGray);
					casilla_5.setBackground(SystemColor.lightGray);
					casilla_7.setBackground(SystemColor.lightGray);
					casilla_8.setBackground(SystemColor.lightGray);
					casilla_11.setBackground(SystemColor.lightGray);
					casilla_12.setBackground(SystemColor.lightGray);
					casilla_14.setBackground(SystemColor.lightGray);

				} else {
					casilla.setBackground(SystemColor.WHITE);
					casilla_5.setBackground(SystemColor.WHITE);
					casilla_7.setBackground(SystemColor.WHITE);
					casilla_8.setBackground(SystemColor.WHITE);
					casilla_11.setBackground(SystemColor.WHITE);
					casilla_12.setBackground(SystemColor.WHITE);
					casilla_14.setBackground(SystemColor.WHITE);
				}

			}
		});
	}

}
