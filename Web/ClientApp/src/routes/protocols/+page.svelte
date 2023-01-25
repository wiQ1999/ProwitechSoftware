<script>
  import { getToken } from "$lib/js-lib/authManager";
  let userData = getToken();
  let personLoggedInId = userData.id;
</script>

<a href="/protocols/getAll">
  <button
    class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
    >Wszystkie protokoły</button
  >
</a>

<a href="/protocols/{personLoggedInId}/performer_protocols">
  <button
    class="mx-auto mb-[2%] p-16 rounded-sm w-1/4 bg-[#007acc] text-white font-semibold flex justify-center"
    >Moje protokoły</button
  >
</a>
