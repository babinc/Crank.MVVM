﻿<Window x:Class="$rootnamespace$.MainView"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="{Binding Title}" Height="385" Width="525" 
        DataContext="{Binding Main, Mode=OneWay, Source={StaticResource Locator}}">
    <Grid Margin="10">

    </Grid>
</Window>
