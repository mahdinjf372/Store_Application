
function LoadChart() {

    var timing = $("#request-timing").val();

    var postData = {
        "timing": timing
    };

    $.post("/Admin/Dashboard/LoadSiteRequestCount", postData, function (data) {
        console.log(data);

        $("#requests-chart").remove();
        $(".chartjs").append("<canvas id=\"requests-chart\" height=\"400\"></canvas>");
        var ctx = $("#requests-chart");
        var chartOptions = {
            responsive: true,
            maintainAspectRatio: false,
            hover: {
                animationDuration: 1000,
            },
            scales: {
                xAxes: [{
                    display: true,
                    gridLines: {
                        color: "#f3f3f3",
                        drawTicks: false,
                    },
                    scaleLabel: {
                        display: true,
                        labelString: 'زمان'
                    }
                }],
                yAxes: [{
                    display: true,
                    gridLines: {
                        color: "#f3f3f3",
                        drawTicks: false,
                    },
                    scaleLabel: {
                        display: true,
                        labelString: 'تعداد درخواست'
                    }
                }]
            }
        };

        var chartData = {
            labels: data.timeLabel,
            datasets: [{
                label: "تعداد درخواست",
                data: data.count,
                backgroundColor: "rgba(255, 95, 32, 0.4)",
                borderColor: "transparent",
                pointBackgroundColor: "#FFF",
                pointBorderColor: "rgba(255, 95, 32,1)",
                pointHoverBackgroundColor: "rgba(255, 95, 32,1)",
                pointRadius: 5,
                pointHoverBorderColor: '#FFF',
                pointHoverRadius: 5,
                pointBorderWidth: 2,
                pointHoverBorderWidth: 2,
            }]
        };

        var config = {
            type: 'line',

            options: chartOptions,

            data: chartData
        };

        var areaChart = new Chart(ctx, config);
        areaChart.remove
    });

}

$(document).ready(LoadChart());