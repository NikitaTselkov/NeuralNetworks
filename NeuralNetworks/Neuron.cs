﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks
{
    public class Neuron
    {

        public List<double> Weights { get; }

        public NeuronType NeuronType { get; }

        public double Output { get; private set; }

        public Neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            //TODO: проверка
            NeuronType = type;
            Weights = new List<double>();

            for (var i = 0; i < inputCount; i++) 
            {
                Weights.Add(1);
            }
        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }

            Output = Sigmoid(sum);
            return Output;
        }

        private double Sigmoid(double x)
        {
           return  1.0 / (1.0 + Math.Pow(Math.E, -x));
        }

        public void SetWeights(params double[] weights)
        {
            //TODO: удалить после возможности удаления сети.
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = weights[i];
            }
        }

        public override string ToString()
        {
            return Output.ToString();
        }

    }
}
