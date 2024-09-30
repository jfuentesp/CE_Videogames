using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaylibEngine
{
    public class Component
    {
        private string m_Name = "GameObject";
        private bool m_IsActive;
        private Engine m_Engine;

        public string Name => m_Name;

        public Component(string name)
        {
            this.m_Name = name;
            this.m_Engine = Engine.GetInstance();
        }

        public void Start()
        {
            m_IsActive = true;
        }

        public void Update()
        {

        }

        public void Destroy()
        {

        }
    }
}
