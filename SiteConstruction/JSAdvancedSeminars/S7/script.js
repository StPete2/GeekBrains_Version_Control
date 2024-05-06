const containerEl = document.querySelector('div.container');
const videoEl = document.createElement('video');

videoEl.src = "./img/video_2024-05-06_10-50-44.mp4";
videoEl.width = '640';
videoEl.height = '480';
videoEl.setAttribute('loop', 'true');
containerEl.appendChild(videoEl);

const playEl = document.createElement('div');
playEl.classList.add('play');
const pauseEl = document.createElement('div');
pauseEl.classList.add('pause');

containerEl.appendChild(playEl);
containerEl.appendChild(pauseEl);

playEl.addEventListener('click', function (e) {
    videoEl.play();
});

pauseEl.addEventListener('click', function (e) {
    videoEl.pause();
})