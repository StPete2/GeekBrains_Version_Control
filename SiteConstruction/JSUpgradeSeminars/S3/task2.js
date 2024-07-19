/* 
Задание №2.
Вы разрабатываете онлайн-магазин по заказу индивидуальных мебельных компонентов.
Посетители сайта могут выбирать разные элементы мебели, цвета и материалы для своего гарнитура. После того, как пользователь собрал свой комплект и сохраняет свой выбор, информация о нем сохраняется в localStorage. При следующем посещении сайта их индивидуальные настройки автоматически загружаются, и они видят ранее созданный мебельный комплект.

1. Создайте базовую HTML-структуру с различными элементами мебели (например, стол, стул, диван) и возможными параметрами для них (цвет, материал, дизайн).
2. Пользователи могут выбирать разные элементы и параметры, чтобы составить свой мебельный гарнитур.
3. После выбора всех желаемых параметров предоставьте кнопку "Сохранить комплект", которая сохраняет текущий выбор пользователя в localStorage.
4. При следующем посещении сайта автоматически загрузите сохраненные параметры из localStorage и отобразите ранее созданный комплект.
5. Убедитесь, что у пользователей есть возможность очистить сохраненные настройки (очистить localStorage).
 */

const saveButtonEl = document.querySelector("#save-btn");
const loadButtonEl = document.querySelector("#load-btn");
const clearButtonEl = document.querySelector("#clear-btn");

const tableColorEl = document.querySelector("#table-color");
const chairMaterialEl = document.querySelector("#chair-material");

const localStorageKey = "settings";

saveButtonEl.addEventListener("click", () => {
    const tableColorValue = tableColorEl.value;
    const chairMaterialValue = chairMaterialEl.value;
    localStorage.setItem(
        localStorageKey,
        JSON.stringify({
            // tableColor: `${tableColorValue}`,
            tableColorValue,
            chairMaterialValue,
            // chairMaterialValue: `${chairMaterialValue}`,
        })
    );
    console.log(localStorage);
});

function loadSettings() {
    if (localStorage.getItem(localStorageKey)) {
        const settings = JSON.parse(localStorage.getItem(localStorageKey));
        tableColorEl.value = settings.tableColorValue;
        chairMaterialEl.value = settings.chairMaterialValue;
    }
}

loadSettings();

loadButtonEl.addEventListener("click", () => {
    loadSettings();
});

clearButtonEl.addEventListener("click", () => {
    if (localStorage.getItem(localStorageKey)) {
        const settings = JSON.parse(localStorage.getItem(localStorageKey));
        tableColorEl.value = "";
        chairMaterialEl.value = "";
        // localStorage.removeItem(localStorageKey); // добавить, если необходимо удалить полностью все настройки. Я бы так не делал.
    }
});
