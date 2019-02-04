using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllInOne.Logic
{
    class TaskPool
    {
        private List<Task> taskList;
        private int activeTaskLimit;
        private int activeTaskCount;
        private Label lbl;
        private ProgressBar pBar;
        public int count
        {
            get
            {
                return taskList.Count;
            }
        }

        public TaskPool(List<Task> taskList, int activeTaskLimit, ref Label lbl)
        {
            this.taskList = taskList;
            this.activeTaskCount = 0;
            this.activeTaskLimit = activeTaskLimit;
            this.lbl = lbl;
        }

        public TaskPool(int activeTaskLimit, ref Label lbl)
        {
            this.taskList = new List<Task>();
            this.activeTaskCount = 0;
            this.activeTaskLimit = activeTaskLimit;
            this.lbl = lbl;
        }

        public TaskPool(List<Task> taskList, int activeTaskLimit, ref ProgressBar pBar)
        {
            this.taskList = taskList;
            this.activeTaskCount = 0;
            this.activeTaskLimit = activeTaskLimit;
            this.pBar = pBar;
        }

        public TaskPool(int activeTaskLimit, ref ProgressBar pBar)
        {
            this.taskList = new List<Task>();
            this.activeTaskCount = 0;
            this.activeTaskLimit = activeTaskLimit;
            this.pBar = pBar;
        }

        //
        public TaskPool(List<Task> taskList, int activeTaskLimit, ref Label lbl , ref ProgressBar pBar)
        {
            this.taskList = taskList;
            this.activeTaskCount = 0;
            this.activeTaskLimit = activeTaskLimit;
            this.pBar = pBar;
            this.lbl = lbl;
        }

        public TaskPool(int activeTaskLimit, ref Label lbl, ref ProgressBar pBar)
        {
            this.taskList = new List<Task>();
            this.activeTaskCount = 0;
            this.activeTaskLimit = activeTaskLimit;
            this.pBar = pBar;
            this.lbl = lbl;
        }

        public void Add(Task task)
        {
            this.taskList.Add(task);
        }

        public void Start()
        {
            UpdateControlProgress(true);
            while (true)
            {
                foreach (Task t in this.taskList)
                {
                    if (this.activeTaskCount <= this.activeTaskLimit)
                    {
                        if (t.Status == TaskStatus.Created)
                        {
                            t.Start();
                            this.activeTaskCount++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                int index = Task.WaitAny(this.taskList.ToArray());
                this.activeTaskCount--;
                this.taskList.RemoveAt(index);

                if (this.taskList.Count != 0)
                {
                    UpdateControlProgress();
                }
                else
                {
                    UpdateControlProgress();
                    break;
                }
            }
        }

        private void UpdateControlProgress(bool reset = false)
        {
            if (this.lbl != null)
            {
                lbl.Invoke(new Action(()=>
                    {
                        lbl.Text = string.Format(Language.inProcess + "[{0}]", this.taskList.Count);
                    }));
            }
            if (this.pBar != null)
            {
                if (reset)
                {
                    pBar.Invoke(new Action(() =>
                    {
                            pBar.Value = 0;
                            pBar.Maximum = this.taskList.Count;
                        }));
                }
                else
                {
                    pBar.Invoke(new Action(() =>
                    {
                            pBar.PerformStep();
                        }));
                }
            }
        }
    }
}
