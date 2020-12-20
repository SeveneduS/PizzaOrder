/// <summary>
/// Eduard Ragimov - 2020
/// </summary>
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<Pizza, int> order = new Dictionary<Pizza, int>();

        public Form1()
        {
            InitializeComponent();

            HoldControl();

            pizzaTypeComboBox.Items.AddRange(PizzaConfig.Pizzas.ToArray());
            pizzaTypeComboBox.SelectedIndex = 0;

            totalAmountLabel.Text = "$ 0.00";

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            ReleaseControl();
        }

        private void HoldControl()
        {
            calculateButton.Enabled = false;
            removeButton.Enabled = false;
            orderAddButton.Enabled = false;
        }

        private void ReleaseControl()
        {
            calculateButton.Enabled = true;
            removeButton.Enabled = true;
            orderAddButton.Enabled = true;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            HoldControl();
            ProcessTheOrder();
            ReleaseControl();
        }

        private void AddToOrder()
        {
            Pizza pizza = (Pizza)pizzaTypeComboBox.SelectedItem;
            if (pizza != null)
            {
                if (order.ContainsKey(pizza))
                {
                    order[pizza] += (int)pizzaAmountUpDown.Value;
                }
                else
                {
                    order.Add(pizza, (int)pizzaAmountUpDown.Value);
                }
            }

            Redraw();
        }


        private void RemoveFromOrder()
        {
            string pizza = orderListBox.SelectedItem?.ToString();

            if (String.IsNullOrEmpty(pizza)) return;

            pizza = pizza.Remove(0, pizza.IndexOf(']') + 1);

            List<Pizza> tmp = new List<Pizza>();

            foreach (var p in order)
            {
                if (p.Key.ToString().Contains(pizza))
                {
                    tmp.Add(p.Key);
                }
            }

            foreach (var pz in tmp)
            {
                order.Remove(pz);
            }

            Redraw();
        }

        private float Calculate()
        {
            float result = 0f;

            var c = Parallel.ForEach(order, (itm) =>
            {
                result += itm.Key.Cost * itm.Value;
            });

            while (!c.IsCompleted) { Thread.Sleep(1); }

            return result;
        }

        private void ProcessTheOrder()
        {
            float amount = 0f;
            var c = Task.Factory.StartNew(
                () =>
                {
                    amount = Calculate();
                });

            c.Wait();

            totalAmountLabel.Text = $"$ {amount:#.00}";
        }

        private void Redraw()
        {
            pizzaAmountUpDown.Value = 1;
            orderListBox.Items.Clear();

            foreach (var p in order)
            {
                orderListBox.Items.Add(Pizza.OrderToString(p));
            }

            orderListBox.Select();
            orderListBox.CheckOnClick = true;
            orderListBox.Refresh();
        }

        private void AddPizza(object sender, EventArgs e)
        {

            HoldControl();
            AddToOrder();
            ReleaseControl();
        }

        private void RemovePizza(object sender, EventArgs e)
        {
            HoldControl();
            RemoveFromOrder();
            ReleaseControl();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
