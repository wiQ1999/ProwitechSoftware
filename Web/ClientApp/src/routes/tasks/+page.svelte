<script>
  //TODO ZMIENIAJ HREF W NAVBARZE W ZALEŻNOŚCI OD TEGO, KTO ZALOGOWANY
  let personLoggedInId = "030B7529-173C-41A8-953D-75BA46B7FC21";
</script>

<a href="/tasks/getAll">
  <button
    class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
    >Wszystkie zadania</button
  >
</a>

<a href="/tasks/{personLoggedInId}/performer_tasks">
  <button
    class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
    >Moje zadania</button
  >
</a>
