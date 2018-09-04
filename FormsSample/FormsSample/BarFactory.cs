using System;
using System.Collections.Generic;
using Urho;
using Urho.Resources;

namespace FormsSample
{
    internal class BarFactory
    {
        public BarFactory(ResourceCache resources)
        {
            _resources = resources;
        }

        private readonly ResourceCache _resources;

        public void AddBarsToScene(Node plotNode, List<Bar> bars, int size)
        {
            for (var i = 0f; i < size * 1.5f; i += 1.5f)
            {
                for (var j = 0f; j < size * 1.5f; j += 1.5f)
                {
                    //here we assume to use "_resources" to load model, texture, etc.
                    var boxNode = plotNode.CreateChild();
                    boxNode.Position = new Vector3(size / 2f - i, 0, size / 2f - j);
                    var box = new Bar(new Color(RandomHelper.NextRandom(), RandomHelper.NextRandom(), RandomHelper.NextRandom(), 0.9f));
                    boxNode.AddComponent(box);
                    box.SetValueWithAnimation((Math.Abs(i) + Math.Abs(j) + 1) / 2f);
                    bars.Add(box);
                }
            }
        }

        public void AddBarsToScene(Node plotNode, List<Bar> bars, int size, ResourceCache resources)
        {
            for (var i = 0f; i < size * 1.5f; i += 1.5f)
            {
                for (var j = 0f; j < size * 1.5f; j += 1.5f)
                {
                    //here we assume to use "_resources" to load model, texture, etc.
                    var boxNode = plotNode.CreateChild();
                    boxNode.Position = new Vector3(size / 2f - i, 0, size / 2f - j);
                    var box = new Bar(new Color(RandomHelper.NextRandom(), RandomHelper.NextRandom(), RandomHelper.NextRandom(), 0.9f));
                    boxNode.AddComponent(box);
                    box.SetValueWithAnimation((Math.Abs(i) + Math.Abs(j) + 1) / 2f);
                    bars.Add(box);
                }
            }
        }

    }
}
