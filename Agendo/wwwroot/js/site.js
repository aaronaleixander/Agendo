﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');

    var calendar = new FullCalendar.Calendar(calendarEl, {
        plugins: ['dayGrid']
    });
    header: {
        left: 'prev,next today',
            center; 'title',
                right; 'dayGridMonth,timeGridWeek,timeGridDay'
    }

    calendar.render();
});