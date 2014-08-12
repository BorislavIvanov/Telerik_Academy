﻿namespace ComputersUI.ConsoleClient.Interfaces
{
    public interface IMotherboard
    {
        int LoadRamValue();

        void SaveRamValue(int value);

        void DrawOnVideoCard(string data);
    }
}
